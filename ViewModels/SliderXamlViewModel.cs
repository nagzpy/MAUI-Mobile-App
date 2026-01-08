using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class SliderXamlViewModel : ObservableObject
    {
        public string Title => Models.Titles.TitleSlider.TitleXaml;
    }
}
