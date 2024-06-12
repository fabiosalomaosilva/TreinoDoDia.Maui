using TreinoDoDia.Maui.ViewModels;

namespace TreinoDoDia.Maui.Pages.Cadastro;

public partial class AlturaView : ContentPage
{
    public AlturaView(AlturaViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}