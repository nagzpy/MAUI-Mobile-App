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
    public partial class PickerChoiceViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task PickerXamlClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(PickerXamlPage));
        }
    }
}
