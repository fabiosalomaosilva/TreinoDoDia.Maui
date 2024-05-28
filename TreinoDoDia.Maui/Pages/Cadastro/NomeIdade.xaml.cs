namespace TreinoDoDia.Maui.Pages.Cadastro;

public partial class NomeIdade : ContentPage
{
    public NomeIdade()
    {
        InitializeComponent();
    }

    private void Avancar(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Peso());
    }

}