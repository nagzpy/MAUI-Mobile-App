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
        }
    }
}
