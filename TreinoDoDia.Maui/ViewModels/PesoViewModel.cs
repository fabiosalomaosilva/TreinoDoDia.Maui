using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TreinoDoDia.Maui.ViewModels;
public partial class PesoViewModel : ObservableObject
{

    [ObservableProperty]
    private int? peso;


    public bool IsValid => Peso != null && Peso != 0;


    [RelayCommand]
    private async Task Save()
    {
        if (IsValid)
        {
            App.MetricasCorporais.Peso = Convert.ToInt32(Peso);
            await Shell.Current.GoToAsync("//NivelTreinoView");
            return;
        }
        await App.Current.MainPage.DisplayAlert("Erro", "Preencha todos os campos", "Ok");
    }
}