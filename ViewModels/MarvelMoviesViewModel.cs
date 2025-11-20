using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Entities;
using MyFirstMAUIMobileApp.Models.Titles;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyFirstMAUIMobileApp.ViewModels;

public partial class MarvelMoviesViewModel : ObservableObject
{
    private List<MarvelMovies> _marvelmovies;
    public string Title => TitleMarvelMoviesCollection.Title;

    //= new() -> constructs an empty ObservableCollection<MarvelMovies>
    //and assigns it to the property — using the target-typed new() shorthand.
    //Same as -> ObservableCollection<MarvelMovies> MarvelMoviesCollection =
    //  new ObservableCollection<MarvelMovies>();
    public ObservableCollection<MarvelMovies> MarvelMoviesCollection { get; } = new();

    public MarvelMoviesViewModel()
    {
        _marvelmovies = MarvelMovies.GetMovies();
        LoadMovies();
    }

    private void LoadMovies()
    {
        try
        {
            MarvelMoviesCollection.Clear();
            foreach (var p in _marvelmovies)
            {
                MarvelMoviesCollection.Add(new MarvelMovies { NameOfMovie = p.NameOfMovie });
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }
}
