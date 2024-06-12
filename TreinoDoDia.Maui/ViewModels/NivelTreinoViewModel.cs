using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TreinoDoDia.Maui.Models;

namespace TreinoDoDia.Maui.ViewModels;

public partial class NivelTreinoViewModel : ObservableObject
{

    [ObservableProperty]
    private int idNivel;

    public List<NivelAtividadeFisica> NiveisAtividadeFisica { get; } = new NivelAtividadeFisica().GetListaAtividadeFisicas();

    public bool IsValid => IdNivel != 0;

    [RelayCommand]
    private async Task Save()
    {
        if (IsValid)
        {
            App.MetricasCorporais.NivelAtividadeFisica = Convert.ToDouble(NiveisAtividadeFisica.First(p => p.Id == IdNivel).Indice);
            await Shell.Current.GoToAsync("//MetaView");
            return;
        }
        await App.Current.MainPage.DisplayAlert("Erro", "Preencha todos os campos", "Ok");
    }
}