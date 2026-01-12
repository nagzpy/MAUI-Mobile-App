using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class SliderVmViewModel : ObservableObject
    {
        public string Title => Models.Titles.TitleSlider.TitleVm;
        public string TitleButton => Models.Titles.TitleSlider.TitleButton;

        [ObservableProperty]
        private double sliderValue;

        [ObservableProperty]
        private string text;

        partial void OnSliderValueChanged(double value)
        {
            Text = $"Value of Slider {Math.Round(sliderValue, 2):F2}";
        }

        [RelayCommand]
        private void SetToHalf()
        {
            SliderValue = 0.50;
        }
    }
    
}