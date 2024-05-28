using CommunityToolkit.Maui;
using DevExpress.Maui;
using Microsoft.Extensions.Logging;

namespace TreinoDoDia.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseDevExpress()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Nunito-Bold.ttf", "NunitoBold");
                    fonts.AddFont("Nunito-Light.ttf", "NunitoLight");
                    fonts.AddFont("Nunito-Medium.ttf", "NunitoMedium");
                    fonts.AddFont("Nunito-Regular.ttf", "NunitoRegular");
                    fonts.AddFont("Nunito-SemiBold.ttf", "NunitoSemiBold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
