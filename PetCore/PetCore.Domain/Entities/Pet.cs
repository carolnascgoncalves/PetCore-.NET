using PetCore.Domain.Enums;

namespace PetCore.Domain.Entities;

public class Pet
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Nome { get; private set; }
    public string Especie { get; private set; }
    public string Raca { get; private set; }
    public DateOnly DataNasc { get; private set; }
    public string Pelagem { get; private set; }
    public string Porte { get; private set; }
    public GeneroSexoEnum Sexo { get; private set; }
    public bool Status { get; private set; }

    // 1:1 Historico
    public Historico Historico { get; set; }

    //N:N Tutor
    public List<Tutor> Tutores { get; set; }
}