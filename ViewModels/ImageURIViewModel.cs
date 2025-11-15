using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ImageURIViewModel : ObservableObject
    {
        public string Title => Models.Titles.TitleImageURI.Title;

        [ObservableProperty]
        private ImageSource imageSourceUrl;

        public ImageURIViewModel()
        {
            imageSourceUrl = new UriImageSource
            {
                Uri = new Uri(Models.Titles.TitleImageURI.ImageURL),
                CachingEnabled = true,
                CacheValidity = TimeSpan.FromDays(1)
            };
        }
    }
}
