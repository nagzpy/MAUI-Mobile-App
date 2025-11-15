using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ImagesViewModel
    {
        public string Title => TitleImages.Title;
        public string URIImage => TitleImages.URIImage;
        public string EmbeddedImage => TitleImages.EmbeddedImage;
        public string ActivityIndicatorImage => TitleImages.ActivityIndicatorImage;

        [RelayCommand]
        private async Task URIImagesClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(Views.ImageURIPage));
        }

        [RelayCommand]
        private async Task EmbeddedImagesClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(Views.ImagesEmbeddedPage));
        }

        [RelayCommand]
        private async Task ActivityIndicatorClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(Views.ActivityIndicatorPage));
        }
    }
}
