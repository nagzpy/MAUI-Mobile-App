using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MyFirstMAUIMobileApp.Models.Entities;
using MyFirstMAUIMobileApp.Models.Messages;
using MyFirstMAUIMobileApp.Models.Titles;
using MyFirstMAUIMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class CollectionUpdatableButtonViewModel : ObservableObject
    {
        public string Title => TitleCollections.CollectionsButtons;

        [ObservableProperty]
        private bool isBusy;

        [ObservableProperty]
        private ObservableCollection<MarvelMovies> movieCollection = new();


        public CollectionUpdatableButtonViewModel()
        {
            // central listener for any UpdateMovieMessage
            WeakReferenceMessenger.Default.Register<UpdateMovieMessage>(this, (r, m) =>
            {
                var oldTitle = m.OldValue.NameOfMovie;
                var idx = MovieCollection.ToList()
                                         .FindIndex(x => x.NameOfMovie == oldTitle);

                if (idx >= 0)
                    MovieCollection[idx] = m.NewValue;
            });

            // kick off initial load
            RefreshCommand.Execute(null);
        }


        [RelayCommand]
        private async Task Refresh()
        {
            if (IsBusy) return;
            IsBusy = true;

            // Use Task.Run to perform the CPU-bound work on a background thread
            await Task.Run(() =>
            {
                MovieCollection.Clear();
                foreach (var mov in MarvelMovies.GetMovies())
                {
                    // Adding items to the collection
                    MovieCollection.Add(mov);
                }
            });

            IsBusy = false;
        }

        [RelayCommand]
        private async Task Add()
        {
            WeakReferenceMessenger.Default.Unregister<AddMovieMessage>(this);

            await Shell.Current.GoToAsync(nameof(CollectionAddPage));

            WeakReferenceMessenger.Default.Register<AddMovieMessage>(this, (r, m) =>
            {
                MovieCollection.Add(m.Value);
                WeakReferenceMessenger.Default.Unregister<AddMovieMessage>(this);
            });
        }


        [RelayCommand]
        private async Task Update(MarvelMovies movie)
        {
            // (No need to register update message here (below), it's already registered in constructor)
            // WeakReferenceMessenger.Default.Unregister<UpdateMovieMessage>(this);
            // Just navigate to the Edit page, encoding the movie name for safe URL transport
            string encodedName = Uri.EscapeDataString(movie.NameOfMovie);
            await Shell.Current.GoToAsync($"{nameof(CollectionEditPage)}?movieName={encodedName}");
        }

        [RelayCommand]
        private void Delete(MarvelMovies movie)
        {
            MovieCollection.Remove(movie);

        }
    }
}
