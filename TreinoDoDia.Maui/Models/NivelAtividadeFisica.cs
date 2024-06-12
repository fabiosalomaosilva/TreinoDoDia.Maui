namespace TreinoDoDia.Maui.Models;

public class NivelAtividadeFisica
{
    public int Id { get; set; }
    public double? Indice { get; set; }
    public string? Descricao { get; set; }

    public List<NivelAtividadeFisica> GetListaAtividadeFisicas()
    {
        return [
            new NivelAtividadeFisica { Id = 1, Indice = 1.2, Descricao = "Sedentário (pouco ou nenhum exercício)" },
            new NivelAtividadeFisica { Id = 2, Indice = 1.375, Descricao = "Levemente ativo (1-2 dias semanais)" },
            new NivelAtividadeFisica { Id = 3, Indice = 1.55, Descricao = "Moderadamente Ativo (3-5 dias semanais)" },
            new NivelAtividadeFisica { Id = 4, Indice = 1.725, Descricao = "Muito Ativo (6-7 dias semanais)" },
            new NivelAtividadeFisica { Id = 5, Indice = 1.9, Descricao = "Extremamente ativo (exercícios muito intensos)" }
        ];
    }
}