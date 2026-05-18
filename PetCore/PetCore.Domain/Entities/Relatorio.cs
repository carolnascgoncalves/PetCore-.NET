namespace PetCore.Domain.Entities;

public class Relatorio
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public String Observacao { get; set; } 
    
    //N:1 Historico
    public Guid IdHistorico { get; set; }
    //N:1 Medico
    public Guid IdMedicoResponsavel { get; set; }
    
    public List<Guid> idClinicas { get; set; }
}