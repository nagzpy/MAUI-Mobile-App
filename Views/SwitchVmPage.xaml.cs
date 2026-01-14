namespace MyFirstMAUIMobileApp.Views;

public partial class SwitchVmPage : ContentPage
{
	public SwitchVmPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.SwitchVmViewModel();
    }
}