using TreinoDoDia.Maui.ViewModels;

namespace TreinoDoDia.Maui.Pages;

public partial class RegisterView : ContentPage
{
    public RegisterView(RegisterViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}