namespace MyFirstMAUIMobileApp.Views;

public partial class SwitchChoice : ContentPage
{
	public SwitchChoice()
	{
		InitializeComponent();
		BindingContext = new ViewModels.SwitchChoiceViewModel();
    }
}