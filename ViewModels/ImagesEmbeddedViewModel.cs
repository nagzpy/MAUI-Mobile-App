using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    class ImagesEmbeddedViewModel
    {
        public string Title => Models.Titles.TitleImagesEmbedded.Title;
        public ImageSource ImageSource => "turkey.jpg";
    }
}
