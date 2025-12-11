using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MyFirstMAUIMobileApp.Models.Entities;
using MyFirstMAUIMobileApp.Models.Messages;
using MyFirstMAUIMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    [QueryProperty(nameof(MovieName), "movieName")]
    public partial class CollectionEditViewModel : ObservableObject
    {
        // Store the original movie name to identify which movie to update
        private string _originalMovieName;

        public string Title => TitleCollections.CollectionsEdit;

        // The ObservableProperty attribute generates the MovieName property with change notification
        // When MovieName changes, the partial method OnMovieNameChanged is called
        [ObservableProperty]
        private string movieName;

        partial void OnMovieNameChanged(string value)
        {
            // Store the original movie name only once
            if (_originalMovieName is null)
            {
                // Save the original movie name for later use
                _originalMovieName = value;
            }
        }

        
        [RelayCommand]
        private async Task UpdateClicked()
        {
            // Validate that the movie name is not empty
            if (string.IsNullOrWhiteSpace(MovieName))
            {
                // Show an alert if the movie name is empty
                await Shell.Current.DisplayAlert(Title, Msgs.NotEmptyMovie, "OK");
                // Exit the method early – No update is performed
                return;
            }

            // Create old and new movie objects for the update
            // Send an update message with the old and new movie details
            var oldMovie = new MarvelMovies(_originalMovieName);
            var newMovie = new MarvelMovies(MovieName);

            // Send the update message using the WeakReferenceMessenger
            WeakReferenceMessenger.Default.Send(new UpdateMovieMessage(oldMovie, newMovie));
            await Shell.Current.GoToAsync("..");
        }

    }

}
