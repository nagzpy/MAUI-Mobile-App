using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIMobileApp.Models.Titles;
using MyFirstMAUIMobileApp.Views;
namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class LayoutsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleLayouts.Title;

        [ObservableProperty]
        private string titleButtonStackLayout = TitleLayouts.TitleButtonStackLayout;

        [ObservableProperty]
        private string titleButtonVerticalStack = TitleLayouts.TitleButtonVerticalStack;

        [ObservableProperty]
        private string titleButtonHorizontalStack = TitleLayouts.TitleButtonHorizontalStack;

        [ObservableProperty]
        private string titleButtonAbsoluteLayout = TitleLayouts.TitleButtonAbsoluteLayout;

        [ObservableProperty]
        private string titleButtonFlexLayout = TitleLayouts.TitleButtonFlexLayout;

        public LayoutsViewModel()
        {
          
        }

        [RelayCommand]
        private async Task LayoutStackClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(LayoutStackPage));
        }

        [RelayCommand]
        private async Task LayoutHorizontalStackClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(LayoutHorizontalStackPage));
        }

        [RelayCommand]
        private async Task LayoutVerticalStackClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(LayoutVerticalStackPage));
        }

        [RelayCommand]
        private async Task LayoutAbsoluteClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(LayoutsAbsolutePage));
        }
    }
}
