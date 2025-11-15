using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstMAUIMobileApp.Models.Titles;
using System.Windows.Input;
using MyFirstMAUIMobileApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleMain.Title;

        [ObservableProperty]
        private string titleButtonLayouts = TitleMain.TitleButtonLayouts;

        [ObservableProperty]
        private string titleButtonImages = TitleMain.TitleButtonImages;

        [ObservableProperty]
        private string titleButtonCollections = TitleMain.TitleButtonCollections;

        [ObservableProperty]
        private string titleButtonControls = TitleMain.TitleButtonControls;

        [ObservableProperty]
        private string titleButtonSQLLite = TitleMain.TitleButtonSQLLite;
        //public ICommand OnLayoutsClicked { get; set; }
        public MainViewModel()
        {
            
            
        }

        [RelayCommand]
        private async Task LayoutsClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(LayoutsPage));
        }

        [RelayCommand]
        private async Task ImagesClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(ImagesPage));
        }
    }
}
