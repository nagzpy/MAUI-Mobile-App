using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class EntryVmViewModel : ObservableObject
    {
        public string TitleVm => Models.Titles.TitleEntry.TitleVm;

        [ObservableProperty]
        private string entryText;

        [RelayCommand]
        private async Task EntryClicked()
        {
            if (!string.IsNullOrWhiteSpace(EntryText)) 
            {
                await Shell.Current.GoToAsync($"{nameof(Views.EntryResultsPage)}?entryText={EntryText}");
            }

            else
            {
                await Shell.Current.DisplayAlert(TitleVm, "Entry can't be empty!", "OK");
            }
        }
    }
}
