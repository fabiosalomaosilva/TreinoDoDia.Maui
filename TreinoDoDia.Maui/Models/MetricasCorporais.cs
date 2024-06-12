using TreinoDoDia.Maui.Models.Enums;

namespace TreinoDoDia.Maui.Models
{
    public class MetricasCorporais
    {
        public string? IdMetricasPessoais { get; set; }
        public string? NomeCompleto { get; set; }
        public int Idade { get; set; }
        public int Altura { get; set; }
        public int Peso { get; set; }
        public int PesoMeta { get; set; }
        public double NivelAtividadeFisica { get; set; }
        public double Imc { get; set; }
        public double TaxaMetabolicaBasal { get; set; }
        public double GastoEnergeticoCaloricoDiario { get; set; }
        public double GastoEnergeticoCaloricoDiarioReduzido { get; set; }
        public int TempoMeta { get; set; }
        public PrazoMeta PrazoMeta { get; set; }
        public Genero Genero { get; set; }
    }
}
