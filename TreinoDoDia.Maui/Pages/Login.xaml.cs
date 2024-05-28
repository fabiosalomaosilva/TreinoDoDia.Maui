using TreinoDoDia.Maui.Pages.Cadastro;

namespace TreinoDoDia.Maui.Pages;

public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();
    }
    private void Entrar(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NomeIdade());
    }
}