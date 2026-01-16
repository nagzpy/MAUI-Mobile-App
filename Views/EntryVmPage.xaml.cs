using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class EntryVmPage : ContentPage
{
	public EntryVmPage()
	{
		InitializeComponent();
		BindingContext = new EntryVmViewModel();
	}
}