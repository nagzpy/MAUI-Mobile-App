using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class LayoutStackPage : ContentPage
{
	public LayoutStackPage()
	{
		InitializeComponent();
		BindingContext = new LayoutStackModel();
	}
}