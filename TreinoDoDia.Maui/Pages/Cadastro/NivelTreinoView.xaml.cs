using TreinoDoDia.Maui.ViewModels;

namespace TreinoDoDia.Maui.Pages.Cadastro;

public partial class NivelTreinoView : ContentPage
{
    public NivelTreinoView(NivelTreinoViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}