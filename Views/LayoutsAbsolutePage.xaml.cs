using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class LayoutsAbsolutePage : ContentPage
{
	public LayoutsAbsolutePage()
	{
		InitializeComponent();
		BindingContext = new LayoutsAbsoluteViewModel();
    }
}