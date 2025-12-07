//Ensure your NAMESPACE is correct
namespace MyFirstMAUIMobileApp.Models.Entities;

public class MarvelMoviesImages
{
    public string NameOfActor { get; set; }
    public string NameInMovie { get; set; }
    public string ImageName { get; set; }

    public MarvelMoviesImages()
    {

    }

    public MarvelMoviesImages(string name, string movieName, string imageName)
    {
        NameOfActor = name; 
        NameInMovie = movieName;
        ImageName = imageName;
    }
    public static List<MarvelMoviesImages> GetActorsCharacter() => new List<MarvelMoviesImages>
    {
        new MarvelMoviesImages("Chris Pratt", "Starlord", "starlord"),
        new MarvelMoviesImages("Zoe Saldana", "Gamora", "gamora"),
        new MarvelMoviesImages("Vin Diesel", "Groot", "groot"),
        new MarvelMoviesImages("Bradley Cooper", "Rocket", "rocket"),
        new MarvelMoviesImages("Karen Gillan", "Nebula", "nebula"),
     };
}
