using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.Views;

public partial class EntryXamlPage : ContentPage
{
	public EntryXamlPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.EntryXamlViewModel();
    }

	
private async void SubmitClicked(object sender, EventArgs e)
{
    string entryText = EntryValue.Text;

    if (string.IsNullOrWhiteSpace(entryText))
    {
        // OLD -> Application.Current.MainPage.DisplayAlert(TitlesEntry.EntryXAMLTitle,
        //              "Entry is empty. Please enter text.", "OK");
        // Entry is empty, show an alert
        await Shell.Current.DisplayAlert(TitleEntry.TitleXaml,
                                         "Entry is empty. Please enter text.", "OK");
    }
    else
    {
        // OLD -> Application.Current.MainPage.DisplayAlert(TitlesEntry.EntryXAMLTitle,
        //              "You entered: " + entryText, "OK");
        // Entry is not empty, notify the user of what they typed
        await Shell.Current.DisplayAlert(TitleEntry.TitleXaml,
                                         "You entered: " + entryText, "OK");
    }
}

}