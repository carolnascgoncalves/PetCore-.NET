namespace PetCore.Domain.Entities;

public class Prontuario
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public DateOnly DataEmissao { get; private set; }
    public string Descricao { get; private set; }
    
    public List<Guid> idExames { get; set; }
    
    public List<Guid> idReceitas { get; set; }
    
    public Guid IdHistorico { get; set; }
    //N:1 Medico 
    public Guid IdMedico { get; set; }
}