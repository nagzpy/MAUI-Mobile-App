using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class CollectionUpdateablePage : ContentPage
{
	public CollectionUpdateablePage(CollectionUpdatableButtonViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}