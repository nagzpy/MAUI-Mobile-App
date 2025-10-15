using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

      
    }
}
