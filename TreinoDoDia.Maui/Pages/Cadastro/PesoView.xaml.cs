using TreinoDoDia.Maui.ViewModels;

namespace TreinoDoDia.Maui.Pages.Cadastro;

public partial class PesoView : ContentPage
{
    public PesoView(PesoViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

}