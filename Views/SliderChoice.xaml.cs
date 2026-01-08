namespace MyFirstMAUIMobileApp.Views;

public partial class SliderChoice : ContentPage
{
	public SliderChoice()
	{
		InitializeComponent();
		BindingContext = new ViewModels.SliderChoiceViewModel();
    }
}