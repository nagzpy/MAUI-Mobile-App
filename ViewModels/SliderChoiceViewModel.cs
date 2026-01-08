using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class SliderChoiceViewModel : ObservableObject
    {
        public string Title => Models.Titles.TitleSliderChoice.Title;
        public string TitleVmSlider => Models.Titles.TitleSliderChoice.TitleVmSlider;
        public string TitleXamlSlider => Models.Titles.TitleSliderChoice.TitleXamlSlider;

        [RelayCommand]
        private async Task VmSliderClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(SliderVmPage));
        }
        
        [RelayCommand]
        private async Task XamlSliderClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(SliderXamlPage));
        }
    }
}