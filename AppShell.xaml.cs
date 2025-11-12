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
        }
    }
}
