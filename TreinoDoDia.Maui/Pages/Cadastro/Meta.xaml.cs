namespace TreinoDoDia.Maui.Pages.Cadastro;

public partial class Meta : ContentPage
{
    public Meta()
    {
        InitializeComponent();
    }

    private void Avancar(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NivelTreino());
    }
}