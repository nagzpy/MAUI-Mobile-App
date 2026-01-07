using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using static System.Math;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class SliderViewModel : ObservableObject
    {
        public string Title => Models.Titles.TitleSlider.Title;
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