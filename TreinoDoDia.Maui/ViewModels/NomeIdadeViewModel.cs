using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TreinoDoDia.Maui.Models;

namespace TreinoDoDia.Maui.ViewModels;
public partial class NomeIdadeViewModel : ObservableObject
{

    [ObservableProperty]
    private string nomeCompleto;

    [ObservableProperty]
    private int? idade;

    [ObservableProperty]
    private int genero;

    public List<GeneroSelect> ListaGeneros { get; set; } = [new GeneroSelect { Descricao = "Masculino", Id = 1 }, new GeneroSelect { Descricao = "Feminino", Id = 2 }];

    public bool IsValid => !string.IsNullOrEmpty(NomeCompleto) && Idade != 0;

    [RelayCommand]
    private async Task Save()
    {
        if (IsValid)
        {
            App.MetricasCorporais.NomeCompleto = NomeCompleto;
            App.MetricasCorporais.Idade = Convert.ToInt32(Idade);
            App.MetricasCorporais.Genero = Genero == 1 ? Models.Enums.Genero.Masculino : Models.Enums.Genero.Feminino;

            await Shell.Current.GoToAsync("//AlturaView");
            return;
        }
        await App.Current.MainPage.DisplayAlert("Erro", "Preencha todos os campos", "Ok");
    }

    [RelayCommand]
    private async void ReturnView()
    {
        await Shell.Current.GoToAsync("//Login");
    }
}