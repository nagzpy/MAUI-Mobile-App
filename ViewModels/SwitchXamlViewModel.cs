using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class SwitchXamlViewModel : ObservableObject
    {
        public string TitleXaml => Models.Titles.TitleSwitch.TitleXaml;
    }
}
