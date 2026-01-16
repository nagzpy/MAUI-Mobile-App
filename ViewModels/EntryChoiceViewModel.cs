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
    public partial class EntryChoiceViewModel : ObservableObject
    {
        public string Title => Models.Titles.TitleEntryChoice.Title;
        public string TitleVmEntry => Models.Titles.TitleEntryChoice.TitleVmEntry;
        public string TitleXamlEntry => Models.Titles.TitleEntryChoice.TitleXamlEntry;

        [RelayCommand]
        private async Task EntryXamlClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(EntryXamlPage));
        }
    }
}
