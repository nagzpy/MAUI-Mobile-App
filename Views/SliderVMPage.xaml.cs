using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class SliderVmPage : ContentPage
{
	public SliderVmPage()
	{
		InitializeComponent();
		BindingContext = new SliderVmViewModel();
	}
}