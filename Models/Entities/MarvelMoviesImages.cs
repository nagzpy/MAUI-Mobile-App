//Ensure your NAMESPACE is correct
namespace MyFirstMAUIMobileApp.Models.Entities;

public class MarvelMoviesImages
{
    public string NameOfActor { get; set; }
    public string NameInMovie { get; set; }

    public MarvelMoviesImages()
    {

    }

    public MarvelMoviesImages(string name, string moviename)
    {
        NameOfActor = name; 
        NameInMovie = moviename;
    }
    public static List<MarvelMoviesImages> GetActorsCharacter() => new List<MarvelMoviesImages>
    {
        new MarvelMoviesImages("Chris Pratt", "Starlord"),
        new MarvelMoviesImages("Zoe Saldana", "Gamora"),
        new MarvelMoviesImages("Vin Diesel", "Groot"),
        new MarvelMoviesImages("Bradley Cooper", "Rocket Raccoon"),
        new MarvelMoviesImages("Karen Gillan", "Nebula"),
     };
}
