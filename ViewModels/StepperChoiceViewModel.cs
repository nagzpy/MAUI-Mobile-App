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
    public partial class StepperChoiceViewModel : ObservableObject
    {
        public string Title => Models.Titles.TitleSliderChoice.Title;
        public string TitleVmStepper => Models.Titles.TitleStepperChoice.TitleVmStepper;
        public string TitleXamlStepper => Models.Titles.TitleStepperChoice.TitleXamlStepper;

        [RelayCommand]
        private async Task VmStepperClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(StepperVmPage));
        }
        
        [RelayCommand]
        private async Task XamlStepperClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(StepperXamlPage));
        }
    }
}