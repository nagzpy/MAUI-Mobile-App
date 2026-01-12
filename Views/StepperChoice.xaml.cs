using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class StepperChoice : ContentPage
{
	public StepperChoice()
	{
		InitializeComponent();
		BindingContext = new StepperChoiceViewModel();
	}
}