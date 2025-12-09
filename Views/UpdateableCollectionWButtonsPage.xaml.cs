using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class UpdateableCollectionWButtonsPage : ContentPage
{
	public UpdateableCollectionWButtonsPage(CollectionUpdatableButtonViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}