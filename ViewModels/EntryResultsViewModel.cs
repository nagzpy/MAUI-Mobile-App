using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    [QueryProperty(nameof(EntryText), "entryText")]
    public partial class EntryResultsViewModel : ObservableObject
    {
        public string Title => Models.Titles.TitleEntry.EntryResultTitle;

        [ObservableProperty]
        private string entryText;
    }
}
