using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TreinoDoDia.Maui.Models;

namespace TreinoDoDia.Maui.ViewModels;
public partial class ResultadoViewModel : ObservableObject
{

    [ObservableProperty]
    private MetricasCorporais metricasCorporais;

    public ResultadoViewModel()
    {
        MetricasCorporais = App.MetricasCorporais;
    }

    [RelayCommand]
    private async Task Avancar()
    {

        await Shell.Current.GoToAsync("//RegisterTreinoView");
    }
}