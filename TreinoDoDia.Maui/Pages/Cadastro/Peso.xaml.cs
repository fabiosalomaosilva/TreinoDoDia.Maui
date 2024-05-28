namespace TreinoDoDia.Maui.Pages.Cadastro;

public partial class Peso : ContentPage
{
    public Peso()
    {
        InitializeComponent();
    }
    private void Avancar(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Altura());
    }
}