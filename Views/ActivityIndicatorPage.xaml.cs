using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ActivityIndicatorPage : ContentPage
{
	public ActivityIndicatorPage()
	{
		InitializeComponent();
		BindingContext = new ActivityIndicatorViewModel();
    }
}