using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TreinoDoDia.Maui.Models;
using TreinoDoDia.Maui.Models.Enums;

namespace TreinoDoDia.Maui.ViewModels;

public partial class MetaViewModel : ObservableObject
{

    [ObservableProperty]
    private int? meta;

    [ObservableProperty]
    private int? prazoMetaSelect;

    public List<GeneroSelect> ListaPrazoMeta { get; set; } = [new GeneroSelect { Descricao = "Curto prazo", Id = 1 }, new GeneroSelect { Descricao = "Longo prazo", Id = 2 }];

    public bool IsValid => Meta != null && Meta != 0;

    [RelayCommand]
    private async Task Save()
    {
        if (IsValid)
        {
            App.MetricasCorporais.PesoMeta = Convert.ToInt32(Meta);
            App.MetricasCorporais.PrazoMeta = PrazoMetaSelect == 1 ? PrazoMeta.Curto : PrazoMeta.Longo;
            Calculate();
            await Shell.Current.GoToAsync("//ResultadosView");
            return;
        }
        await App.Current.MainPage.DisplayAlert("Erro", "Preencha todos os campos", "Ok");
    }

    private void Calculate()
    {
        var taxGender = new IndiceCalculo(App.MetricasCorporais.Genero);

        var tmb = taxGender.Idade + (taxGender.Peso * App.MetricasCorporais.Peso) + (taxGender.Altura * App.MetricasCorporais.Altura) - (taxGender.Idade * App.MetricasCorporais.Idade);
        var gcd = tmb * App.MetricasCorporais.NivelAtividadeFisica;

        App.MetricasCorporais.TaxaMetabolicaBasal = Math.Round(tmb, 2);

        var gastoCaloricoAtual = Math.Round(gcd, 2);
        var reducaoCalorias = PrazoMetaSelect == 1 ? CalcularReducaoRapidaCalorias(App.MetricasCorporais.Idade) : CalcularReducaoLentaCalorias(App.MetricasCorporais.Idade);
        var quilosParaPerder = App.MetricasCorporais.Peso - App.MetricasCorporais.PesoMeta;
        var tempoMeta = CalcularTempoParaEmagrecer(gastoCaloricoAtual, reducaoCalorias, quilosParaPerder);
        var gastoCaloricoReduzido = Math.Round(gastoCaloricoAtual - reducaoCalorias, 2);

        App.MetricasCorporais.GastoEnergeticoCaloricoDiario = gastoCaloricoAtual;
        App.MetricasCorporais.TempoMeta = tempoMeta;
        App.MetricasCorporais.GastoEnergeticoCaloricoDiarioReduzido = gastoCaloricoReduzido;

    }

    private double CalcularReducaoRapidaCalorias(int idade)
    {
        switch (idade)
        {
            case >= 18 and <= 29:
                return 1000;
            case >= 30 and <= 60:
                {
                    var m = (500 - 1000) / (60 - 30.0);
                    var b = 1000 - m * 30;
                    return m * idade + b;
                }
            default:
                return 500;
        }
    }

    private double CalcularReducaoLentaCalorias(int idade)
    {
        switch (idade)
        {
            case >= 18 and <= 29:
                return 600;
            case >= 30 and <= 60:
                {
                    var m = (250 - 600) / (60 - 30.0);
                    var b = 600 - m * 30;
                    return m * idade + b;
                }
            default:
                return 250;
        }
    }

    private int CalcularTempoParaEmagrecer(double gastoCaloricoDiario, double reducaoCaloricaDiaria, int pesoEmKgParaPerder)
    {
        // 1 kg de gordura corporal é aproximadamente 7700 calorias
        const double caloriasPorKg = 7700;

        if (reducaoCaloricaDiaria <= 0)
        {
            throw new ArgumentException("A redução calórica diária deve ser menor que o gasto calórico diário para que ocorra perda de peso.");
        }

        var totalCaloriasParaPerder = pesoEmKgParaPerder * caloriasPorKg;
        var diasParaEmagrecer = totalCaloriasParaPerder / reducaoCaloricaDiaria;
        var semanasParaEmagrecer = Math.Ceiling(diasParaEmagrecer / 7);

        return Convert.ToInt32(semanasParaEmagrecer);
    }
}