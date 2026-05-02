namespace PetCore.Domain.Entities;

public class Prontuario
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public DateOnly DataEmissao { get; private set; }
    public string Descricao { get; private set; }
    
    public Guid IdPetVinculado { get; set; }
    public Guid IdTutorResponsavel { get; set; }
    public Guid IdHistoricoPertencente { get; set; }
    //N:1 Medico 
    public Guid IdMedicoResponsavel { get; set; }
}