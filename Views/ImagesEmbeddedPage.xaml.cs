using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ImagesEmbeddedPage : ContentPage
{
	public ImagesEmbeddedPage()
	{
		InitializeComponent();
		BindingContext = new ImagesEmbeddedViewModel();
	}
}