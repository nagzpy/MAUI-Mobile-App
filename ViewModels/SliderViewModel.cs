using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class SliderViewModel
    {
        public string Title => Models.Titles.TitleSlider.Title;

        UpdateVisuals(MySlider.Value);

        SetPlatformPadding();
    }
}
