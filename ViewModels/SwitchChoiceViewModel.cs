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
    public partial class SwitchChoiceViewModel : ObservableObject
    {
        public string Title => Models.Titles.TitleSwitchChoice.Title;
        public string TitleVmSwitch => Models.Titles.TitleSwitchChoice.TitleVmSwitch;
        public string TitleXamlSwitch => Models.Titles.TitleSwitchChoice.TitleXamlSwitch;

        [RelayCommand]
        private async Task SwitchXamlClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(SwitchXamlPage));
        }

        [RelayCommand]
        private async Task SwitchVmClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(SwitchVmPage));
        }
    }
}
