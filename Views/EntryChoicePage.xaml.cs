namespace MyFirstMAUIMobileApp.Views;

public partial class EntryChoicePage : ContentPage
{
	public EntryChoicePage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.EntryChoiceViewModel();
    }
}