namespace MyFirstMAUIMobileApp.Views;

public partial class ControlsPage : ContentPage
{
	public ControlsPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.ControlsViewModel();
    }
}