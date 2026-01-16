using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class EntryResultsPage : ContentPage, IQueryAttributable
{
	public EntryResultsPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.EntryResultsViewModel();
    }
	
    // Called by Shell after construction, with the query dictionary
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        // Shell navigation can only pass query parameters to Pages, not directly to ViewModels.
        // Because Shell creates the Page first (using a parameterless constructor),
        // we must receive the parameter here and then forward it to the ViewModel.
        // This keeps MVVM intact while working within Shell's navigation constraints.
        if (BindingContext is EntryResultsViewModel vm
            && query.TryGetValue("entryText", out var value)
            && value is string text)
        {
            // Manually forward the Shell parameter to EntryResultsViewModel.EntryText
            // because Shell cannot inject parameters directly into the ViewModel.
            vm.EntryText = text;
        }
    }

}