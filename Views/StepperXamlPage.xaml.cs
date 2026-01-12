using Microsoft.Maui.Controls;
using MyFirstMAUIMobileApp.ViewModels;
namespace MyFirstMAUIMobileApp.Views;

public partial class StepperXamlPage : ContentPage
{
    public StepperXamlPage()
    {
        InitializeComponent();
        BindingContext = new StepperXamlViewModel();

        // Make initial UI state match the stepper's starting value
        UpdateUI(stepper.Value);
    }

    private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateUI(e.NewValue);
    }

    private void UpdateUI(double value)
    {
        RotatingLabel.Rotation = value;
        DisplayLabel.Text = $"The Stepper value is {value:F0}";
    }
}
