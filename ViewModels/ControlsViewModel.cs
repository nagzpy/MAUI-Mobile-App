using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ControlsViewModel
    {
        public string Title => Models.Titles.TitleControls.Title;
        public string TitleSwitch => Models.Titles.TitleControls.TitleSwitch;
        public string TitleStepper => Models.Titles.TitleControls.TitleStepper;
        public string TitleSlider => Models.Titles.TitleControls.TitleSlider;
        public string TitleDateTime => Models.Titles.TitleControls.TitleDateTime;
        public string TitlePicker => Models.Titles.TitleControls.TitlePicker;
        public string TitleEntry => Models.Titles.TitleControls.TitleEntry;

        [RelayCommand]
        private async Task SliderClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(SliderPage));
        }
    }
}
