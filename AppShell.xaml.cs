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
            //Routes from Main Page
            Routing.RegisterRoute(nameof(Views.LayoutsPage), typeof(Views.LayoutsPage));
            
            //Routes from Layouts Page
            Routing.RegisterRoute(nameof(Views.LayoutStackPage), typeof(Views.LayoutStackPage));
        }
    }
}
