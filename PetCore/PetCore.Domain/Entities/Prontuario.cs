namespace PetCore.Domain.Entities;

public class Prontuario
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public DateOnly DataEmissao { get; private set; }
    public string Descricao { get; private set; }
    
    public Pet PetVinculado { get; set; }
    public Tutor TutorResponsavel { get; set; }
    public Historico HistoricoPertencente { get; set; }
    //N:1 Medico 
    public Medico MedicoResponsavel { get; set; }
}