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
    public static List<MarvelMoviesImages> GetActors() => new List<MarvelMoviesImages>
    {
        new MarvelMoviesImages("Chris Pratt"),
        new MarvelMoviesImages("Zoe Saldana"),
        new MarvelMoviesImages("Chris Pratt"),
     };
}
