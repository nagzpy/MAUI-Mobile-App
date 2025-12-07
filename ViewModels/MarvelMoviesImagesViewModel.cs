using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class MarvelMoviesImagesViewModel : ObservableObject
    {
        public string Title => Models.Titles.TitleMarvelMoviesImages.Title;
        public ImageSource gamora => "gamora.jpg";
        public ImageSource groot => "groot.jpg";
        public ImageSource nebula => "nebula.jpg";
        public ImageSource rocket => "rocket.jpg";
        public ImageSource starlord => "starlord.jpg";
        private List<MarvelMoviesImages> _marvelmoviesimages;

        //= new() -> constructs an empty ObservableCollection<MarvelMovies>
        //and assigns it to the property — using the target-typed new() shorthand.
        //Same as -> ObservableCollection<MarvelMovies> MarvelMoviesCollection =
        //  new ObservableCollection<MarvelMovies>();
        public ObservableCollection<MarvelMoviesImages> MarvelMoviesImagesCollection { get; } = new();

        public MarvelMoviesImagesViewModel()
        {
            _marvelmoviesimages = MarvelMoviesImages.GetActorsCharacter();
            LoadActorsCharacter();
        }

        private void LoadActorsCharacter()
        {
            try
            {
                MarvelMoviesImagesCollection.Clear();
                foreach (var p in _marvelmoviesimages)
                {
                    MarvelMoviesImagesCollection.Add(new MarvelMoviesImages { NameOfActor = p.NameOfActor, NameInMovie = p.NameInMovie, ImageName = p.ImageName});
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        }
}
