namespace MyFirstMAUIMobileApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }
        private void RegisterRoutes()
        {
            //Layouts
            Routing.RegisterRoute(nameof(Views.LayoutsPage), typeof(Views.LayoutsPage));
            Routing.RegisterRoute(nameof(Views.LayoutStackPage), typeof(Views.LayoutStackPage));
            Routing.RegisterRoute(nameof(Views.LayoutHorizontalStackPage), typeof(Views.LayoutHorizontalStackPage));
            Routing.RegisterRoute(nameof(Views.LayoutVerticalStackPage), typeof(Views.LayoutVerticalStackPage));
            Routing.RegisterRoute(nameof(Views.LayoutsAbsolutePage), typeof(Views.LayoutsAbsolutePage));
            Routing.RegisterRoute(nameof(Views.LayoutFlexPage), typeof(Views.LayoutFlexPage));

            //Images
            Routing.RegisterRoute(nameof(Views.ImagesPage), typeof(Views.ImagesPage));
            Routing.RegisterRoute(nameof(Views.ImageURIPage), typeof(Views.ImageURIPage));
            Routing.RegisterRoute(nameof(Views.ImagesEmbeddedPage), typeof(Views.ImagesEmbeddedPage));
            Routing.RegisterRoute(nameof(Views.ActivityIndicatorPage), typeof(Views.ActivityIndicatorPage));

            //Collections
            Routing.RegisterRoute(nameof(Views.CollectionsPage), typeof(Views.CollectionsPage));
            Routing.RegisterRoute(nameof(Views.MarvelMoviesPage), typeof(Views.MarvelMoviesPage));
            Routing.RegisterRoute(nameof(Views.MarvelMoviesImagesPage), typeof(Views.MarvelMoviesImagesPage));
            Routing.RegisterRoute(nameof(Views.CollectionAddPage), typeof(Views.CollectionAddPage));
            Routing.RegisterRoute(nameof(Views.CollectionEditPage), typeof(Views.CollectionEditPage));
            Routing.RegisterRoute(nameof(Views.UpdateableCollectionWButtonsPage), typeof(Views.UpdateableCollectionWButtonsPage));
            Routing.RegisterRoute(nameof(Views.CollectionUpdateablePage), typeof(Views.CollectionUpdateablePage));

            //Controls
            Routing.RegisterRoute(nameof(Views.ControlsPage), typeof(Views.ControlsPage));
            Routing.RegisterRoute(nameof(Views.SliderVmPage), typeof(Views.SliderVmPage));
            Routing.RegisterRoute(nameof(Views.SliderChoice), typeof(Views.SliderChoice));
            Routing.RegisterRoute(nameof(Views.SliderXamlPage), typeof(Views.SliderXamlPage));
            Routing.RegisterRoute(nameof(Views.StepperChoice), typeof(Views.StepperChoice));
            Routing.RegisterRoute(nameof(Views.StepperVmPage), typeof(Views.StepperVmPage));
            Routing.RegisterRoute(nameof(Views.StepperXamlPage), typeof(Views.StepperXamlPage));
            Routing.RegisterRoute(nameof(Views.SwitchChoice), typeof(Views.SwitchChoice));
            Routing.RegisterRoute(nameof(Views.SwitchXamlPage), typeof(Views.SwitchXamlPage));
            Routing.RegisterRoute(nameof(Views.SwitchVmPage), typeof(Views.SwitchVmPage));
            Routing.RegisterRoute(nameof(Views.EntryChoicePage), typeof(Views.EntryChoicePage));
            Routing.RegisterRoute(nameof(Views.EntryXamlPage), typeof(Views.EntryXamlPage));
            Routing.RegisterRoute(nameof(Views.EntryResultsPage), typeof(Views.EntryResultsPage));
            Routing.RegisterRoute(nameof(Views.EntryVmPage), typeof(Views.EntryVmPage));
            Routing.RegisterRoute(nameof(Views.PickerChoice), typeof(Views.PickerChoice));
            Routing.RegisterRoute(nameof(Views.PickerXamlPage), typeof(Views.PickerXamlPage));
            Routing.RegisterRoute(nameof(Views.PickerResultsPage), typeof(Views.PickerResultsPage));
        }
    }
}
