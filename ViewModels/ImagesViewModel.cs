using MyFirstMAUIMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    internal class ImagesViewModel
    {
        public string Title => TitleImages.Title;
        public string URIImage => TitleImages.URIImage;
        public string EmbeddedImage => TitleImages.EmbeddedImage;
        public string ActivityIndicatorImage => TitleImages.ActivityIndicatorImage;
    }
}
