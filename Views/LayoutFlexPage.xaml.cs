using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class LayoutFlexPage : ContentPage
{
	public LayoutFlexPage()
	{
		InitializeComponent();
		BindingContext = new LayoutFlexViewModel();
    }
}