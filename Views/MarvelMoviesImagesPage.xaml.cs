namespace MyFirstMAUIMobileApp.Views;

public partial class MarvelMoviesImagesPage : ContentPage
{
	public MarvelMoviesImagesPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.MarvelMoviesImagesViewModel();
    }
}