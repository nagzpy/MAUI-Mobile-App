using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class PickerResultsPage : ContentPage
{
	public PickerResultsPage()
	{
		InitializeComponent();
		BindingContext = new PickerResultsViewModel();
	}
}