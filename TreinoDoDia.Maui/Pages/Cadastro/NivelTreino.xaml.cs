namespace TreinoDoDia.Maui.Pages.Cadastro;

public partial class NivelTreino : ContentPage
{
    public NivelTreino()
    {
        InitializeComponent();
    }

    private void Avancar(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Meta());
    }
}