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
            Routing.RegisterRoute(nameof(Views.LayoutsPage), typeof(Views.LayoutsPage));
        }
    }
}
