using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace MyFirstMAUIMobileApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }).UseMauiCommunityToolkit();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            try
            {
                builder.Services.AddSingleton<ViewModels.CollectionUpdatableButtonViewModel>();
                builder.Services.AddTransient<Views.UpdateableCollectionWButtonsPage>();
            }
            catch (Exception ex)
            {
                
            }
            return builder.Build();
        }
    }
}