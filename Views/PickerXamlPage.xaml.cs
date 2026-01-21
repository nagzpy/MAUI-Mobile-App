using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class PickerXamlPage : ContentPage
{
	
private readonly Dictionary<string, string> _carImages = new()
    {
        { "1970 Chevy Corvette", "chevycorvette1970.jpg" },
        { "1979 Chevy Camaro",   "chevycamaro1979.jpg" },
        { "1970 Chevy Nova",     "chevynova1970.jpg" },
        { "1975 Dodge Charger",  "dodgecharger1975.jpg" },
        { "1972 Pontiac GTO",    "pontiacgto1972.jpg" }
    };

	public PickerXamlPage()
	{
		InitializeComponent();
        BindingContext = new PickerResultsViewModel();
        btnSubmit.Source = "buttonsubmit.png";
    }
    
private async void btnSubmit_Clicked(object sender, EventArgs e)
{
    string selectedCar = pickerXAML.SelectedItem?.ToString() ?? string.Empty;

    if (string.IsNullOrEmpty(selectedCar))
    {
        await DisplayAlert("Selection Required", "A selection must be made!", "Ok");
        return;
    }

    if (!_carImages.TryGetValue(selectedCar, out string imageFile))
    {
        await DisplayAlert("Error", "No image found for this selection.", "Ok");
        return;
    }

    // Navigate using ONLY what the Picker provides
    await Shell.Current.GoToAsync($"{nameof(PickerResultsPage)}" +
                                  $"?car={Uri.EscapeDataString(selectedCar)}" +
                                  $"&image={Uri.EscapeDataString(imageFile)}");
}

}