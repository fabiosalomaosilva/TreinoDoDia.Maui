using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TreinoDoDia.Maui.ViewModels;
public partial class AlturaViewModel : ObservableObject
{
    [ObservableProperty]
    private int? altura;

    public bool IsValid => Altura != null && Altura != 0;


    [RelayCommand]
    private async Task Save()
    {
        if (IsValid)
        {
            App.MetricasCorporais.Altura = Convert.ToInt32(Altura);
            await Shell.Current.GoToAsync("//PesoView");
            return;
        }

        await App.Current.MainPage.DisplayAlert("Erro", "Preencha todos os campos", "Ok");
    }

    [RelayCommand]
    private async Task GoBack()
    {
        await Shell.Current.GoToAsync("//NomeIdadeView");
    }
}