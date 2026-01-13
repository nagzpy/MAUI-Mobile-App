using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class StepperVmViewModel : ObservableObject
    {
        public string TitleVm => Models.Titles.TitleStepper.TitleVm;

        [ObservableProperty]
        private int stepperValue;
    }
}
