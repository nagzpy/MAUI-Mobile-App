using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class SwitchXamlPage : ContentPage
{
	public SwitchXamlPage()
	{
		InitializeComponent();
		BindingContext = new SwitchXamlViewModel();
    }

	
        private void SwitchToggled(object sender, ToggledEventArgs e)
        {
            // Set label color based on switch value using the ternary operator
            label.TextColor = e.Value
                ? Color.FromRgb(0, 0, 255)   // Blue
                : Color.FromRgb(255, 0, 0);  // Red
        }

}