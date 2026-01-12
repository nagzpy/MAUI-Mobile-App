namespace MyFirstMAUIMobileApp.Views;

public partial class StepperVmPage : ContentPage
{
	public StepperVmPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.StepperVmViewModel();
    }
}