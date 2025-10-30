using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class LayoutHorizontalStackPage : ContentPage
{
	public LayoutHorizontalStackPage()
	{
		InitializeComponent();
		BindingContext = new LayoutHorizontalStackPageViewModel();
	}
}