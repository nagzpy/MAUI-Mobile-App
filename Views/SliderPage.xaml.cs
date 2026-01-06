using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class SliderPage : ContentPage
{
	public SliderPage()
	{
		InitializeComponent();
		BindingContext = new SliderViewModel();
	}
}