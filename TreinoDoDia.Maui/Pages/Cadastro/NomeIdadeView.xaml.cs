using TreinoDoDia.Maui.ViewModels;

namespace TreinoDoDia.Maui.Pages.Cadastro;

public partial class NomeIdadeView : ContentPage
{
    public NomeIdadeView(NomeIdadeViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}