using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class SwitchVmViewModel : ObservableObject
    {
        public string TitleVm => Models.Titles.TitleSwitch.TitleVm;

        [ObservableProperty]
        private bool isOn;

        [ObservableProperty]
        private Color textColor = Colors.CadetBlue;

        partial void OnIsOnChanged(bool value)
        {
            TextColor = value ? Colors.DarkOrange : Colors.CadetBlue;
        }
    }
}
