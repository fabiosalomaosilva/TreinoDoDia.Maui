using CommunityToolkit.Maui;
using DevExpress.Maui;
using Microsoft.Extensions.Logging;
using TreinoDoDia.Maui.Pages;
using TreinoDoDia.Maui.Pages.Cadastro;
using TreinoDoDia.Maui.ViewModels;

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

            builder.Services.AddSingleton<AppShellViewModel>();

            builder.Services.AddSingleton<LoginViewModel>();
            builder.Services.AddSingleton<Login>();

            builder.Services.AddSingleton<NomeIdadeViewModel>();
            builder.Services.AddSingleton<NomeIdadeView>();

            builder.Services.AddSingleton<AlturaViewModel>();
            builder.Services.AddSingleton<AlturaView>();

            builder.Services.AddSingleton<PesoViewModel>();
            builder.Services.AddSingleton<PesoView>();

            builder.Services.AddSingleton<MetaViewModel>();
            builder.Services.AddSingleton<MetaView>();

            builder.Services.AddSingleton<NivelTreinoViewModel>();
            builder.Services.AddSingleton<NivelTreinoView>();

            builder.Services.AddSingleton<ResultadoViewModel>();
            builder.Services.AddSingleton<ResultadosView>();

            builder.Services.AddSingleton<RegisterViewModel>();
            builder.Services.AddSingleton<RegisterView>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
