namespace TreinoDoDia.Maui.Pages.Cadastro;

public partial class Altura : ContentPage
{
    public Altura()
    {
        InitializeComponent();
    }

    private void Avancar(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NivelTreino());
    }
}