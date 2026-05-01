namespace PetCore.Domain.Entities;

public class Relatorio
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    
    //N:1 Historico
    public Historico Historico { get; set; }
    //N:1 Medico
    public Medico MedicoResponsavel { get; set; }
}