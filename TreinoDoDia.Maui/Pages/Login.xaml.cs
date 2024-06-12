using TreinoDoDia.Maui.ViewModels;

namespace TreinoDoDia.Maui.Pages;

public partial class Login : ContentPage
{
    public Login(LoginViewModel loginViewModel)
    {
        InitializeComponent();
        BindingContext = loginViewModel;
    }
}