using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ActivityIndicatorViewModel : ObservableObject
    {
        public string Title => Models.Titles.TitleActivityIndicator.Title;

        [ObservableProperty]
        private bool isLoading = true;

        [ObservableProperty]
        private bool isImageVisible = false;

        [ObservableProperty]
        private ImageSource loadedImage;

        public ActivityIndicatorViewModel()
        {
          _ = LoadImageAsync();
        }
        
        private async Task LoadImageAsync()
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync(Models.Titles.TitleActivityIndicator.ImageURL);

                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    LoadedImage = ImageSource.FromStream(() => stream);
                    IsImageVisible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}
