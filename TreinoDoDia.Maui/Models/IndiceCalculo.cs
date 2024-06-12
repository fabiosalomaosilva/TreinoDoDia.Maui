using TreinoDoDia.Maui.Models.Enums;

namespace TreinoDoDia.Maui.Models;

public class IndiceCalculo
{
    public double IndicePorGenero { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }
    public double Idade { get; set; }

    public IndiceCalculo(Genero genero)
    {
        if (genero == Genero.Masculino)
        {
            IndicePorGenero = 88.36;
            Peso = 13.4;
            Altura = 4.8;
            Idade = 5.7;
        }
        else
        {
            IndicePorGenero = 447.6;
            Peso = 9.2;
            Altura = 3.1;
            Idade = 4.3;
        }
    }
}