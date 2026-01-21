namespace MyFirstMAUIMobileApp.Views;

public partial class PickerChoice : ContentPage
{
	public PickerChoice()
	{
		InitializeComponent();
		BindingContext = new ViewModels.PickerChoiceViewModel();
    }
}