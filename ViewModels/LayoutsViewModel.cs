using MyFirstMAUIMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstMAUIMobileApp.ViewModels
{
    public class LayoutsViewModel : BaseViewModel
    {
        public LayoutsViewModel()
        {
            Title = TitleLayouts.Title;
            TitleButtonStackLayout = TitleLayouts.TitleButtonStackLayout;
            TitleButtonVerticalStack = TitleLayouts.TitleButtonVerticalStack;
            TitleButtonHorizontalStack = TitleLayouts.TitleButtonHorizontalStack;
            TitleButtonAbsoluteLayout = TitleLayouts.TitleButtonAbsoluteLayout;
        }

        public string TitleButtonStackLayout { get; }
        public string TitleButtonVerticalStack { get; }
        public string TitleButtonHorizontalStack { get; }
        public string TitleButtonAbsoluteLayout { get; }
    }
}
