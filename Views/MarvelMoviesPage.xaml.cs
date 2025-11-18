namespace MyFirstMAUIMobileApp.Views;

public partial class MarvelMoviesPage : ContentPage
{
	public MarvelMoviesPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.MoviesCollectionViewModel();
    }
}