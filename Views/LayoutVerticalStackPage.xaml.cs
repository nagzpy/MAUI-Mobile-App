using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class LayoutVerticalStackPage : ContentPage
{
	public LayoutVerticalStackPage()
	{
		InitializeComponent();
		BindingContext = new LayoutVerticalStackViewModel();
    }
}