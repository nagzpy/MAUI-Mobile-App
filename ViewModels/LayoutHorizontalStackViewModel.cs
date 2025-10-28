using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class LayoutHorizontalStackPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleLayoutHorizontalStackPage.Title;
    }
}
