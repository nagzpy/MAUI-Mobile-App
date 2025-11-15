using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ImageURIPage : ContentPage
{
	public ImageURIPage()
	{
		InitializeComponent();
		BindingContext = new ImageURIViewModel();
	}
}