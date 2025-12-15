using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class CollectionsViewModel : ObservableObject
    {
        public string Title => Models.Titles.TitleCollections.Title;
        public string Collections => Models.Titles.TitleCollections.Collections;
        public string CollectionsImages => Models.Titles.TitleCollections.CollectionsImages;
        public string CollectionButtons => Models.Titles.TitleCollections.CollectionsButtons;
        public string CollectionIcons => Models.Titles.TitleCollections.CollectionsIcons;

        [RelayCommand]
        private async Task CollectionClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(Views.MarvelMoviesPage));
        }

        [RelayCommand]
        private async Task CollectionImagesClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(Views.MarvelMoviesImagesPage));
        }

        [RelayCommand]
        private async Task CollectionButtonClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(Views.UpdateableCollectionWButtonsPage));
        }
        
        [RelayCommand]
        private async Task CollectionIconsClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(Views.CollectionUpdateablePage));
        }
    }
}
