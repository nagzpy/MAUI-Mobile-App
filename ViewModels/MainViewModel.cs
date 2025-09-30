using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstMAUIMobileApp.Models.Titles;
using System.Windows.Input;
using MyFirstMAUIMobileApp.Views;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public string TitleButtonLayouts { get; }
        public string TitleButtonImages { get; }
        public string TitleButtonCollections { get; }
        public string TitleButtonControls { get; }
        public string TitleButtonSQLLite { get; }
        public ICommand OnLayoutsClicked { get; set; }
        public MainViewModel()
        {
            Title = TitleMain.Title;
            TitleButtonLayouts = TitleMain.TitleButtonLayouts;
            TitleButtonImages = TitleMain.TitleButtonImages;
            TitleButtonCollections = TitleMain.TitleButtonCollections;
            TitleButtonControls = TitleMain.TitleButtonControls;
            TitleButtonSQLLite = TitleMain.TitleButtonSQLLite;
            OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
        }
        public async void OnLayoutsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
        }
    }
}
