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
        public ICommand OnLayoutsClicked { get; set; }
        public MainViewModel()
        {
            Title = TitleMain.Title;
            OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
        }
        public async void OnLayoutsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
        }
    }
}
