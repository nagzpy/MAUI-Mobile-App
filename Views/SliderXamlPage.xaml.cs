namespace MyFirstMAUIMobileApp.Views;

public partial class SliderXamlPage : ContentPage
{
	public SliderXamlPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.SliderXamlViewModel();
		
		// set the initial text & opacity
        UpdateVisuals(MySlider.Value);

        // platform padding (unchanged)
        SetPlatformPadding();

    }
	
    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        => UpdateVisuals(e.NewValue);
	
    private void UpdateVisuals(double value)
    {
        // fade the bar
        MyBox.Opacity = value;

        // update the numeric label
        ValueLabel.Text = $"Value of the slider is {value:F2}";

        // fade the info text
        InfoLabel.Opacity = value;
    }

    private void SetPlatformPadding()
    {
        if (DeviceInfo.Platform == DevicePlatform.iOS
            || DeviceInfo.Platform == DevicePlatform.Android)
        {
            Padding = new Thickness(25);
        }
        else
        {
            Padding = Thickness.Zero;
        }
    }

}