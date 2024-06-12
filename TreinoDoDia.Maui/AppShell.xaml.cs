using TreinoDoDia.Maui.Pages;
using TreinoDoDia.Maui.Pages.Cadastro;
using TreinoDoDia.Maui.ViewModels;

namespace TreinoDoDia.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            BindingContext = new AppShellViewModel();
            Routing.RegisterRoute(nameof(Login), typeof(Login));
            Routing.RegisterRoute(nameof(RegisterView), typeof(RegisterView));
            Routing.RegisterRoute(nameof(NomeIdadeView), typeof(NomeIdadeView));
            Routing.RegisterRoute(nameof(AlturaView), typeof(AlturaView));
            Routing.RegisterRoute(nameof(PesoView), typeof(PesoView));
            Routing.RegisterRoute(nameof(NivelTreinoView), typeof(NivelTreinoView));
            Routing.RegisterRoute(nameof(MetaView), typeof(MetaView));
            Routing.RegisterRoute(nameof(ResultadosView), typeof(ResultadosView));

        }
    }
}
