namespace MyFirstMAUIMobileApp.Views;

public partial class CollectionAddPage : ContentPage
{
	public CollectionAddPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.CollectionAddViewModel();
    }
}