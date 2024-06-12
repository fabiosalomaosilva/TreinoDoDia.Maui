using TreinoDoDia.Maui.ViewModels;

namespace TreinoDoDia.Maui.Pages.Cadastro;

public partial class ResultadosView : ContentPage
{
    public ResultadosView(ResultadoViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}