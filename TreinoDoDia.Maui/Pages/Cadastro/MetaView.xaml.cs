using TreinoDoDia.Maui.ViewModels;

namespace TreinoDoDia.Maui.Pages.Cadastro;

public partial class MetaView : ContentPage
{
    public MetaView(MetaViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}