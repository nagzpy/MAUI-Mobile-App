using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ImagesPage : ContentPage
{
	public ImagesPage()
	{
		InitializeComponent();
		BindingContext = new ImagesViewModel();
	}
}