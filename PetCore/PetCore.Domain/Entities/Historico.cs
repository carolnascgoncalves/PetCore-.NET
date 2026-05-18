namespace PetCore.Domain.Entities;

public class Historico
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public DateOnly DataAbertura { get; private set; }
    public bool Status { get; private set; }
    
    public Guid IdPet { get; private set; }
    
    public List<Guid> IdRelatorios { get; private set; }
    
    public List<Guid> IdProntuarios { get; private set; }
    
}