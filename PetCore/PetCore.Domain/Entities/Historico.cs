namespace PetCore.Domain.Entities;

public class Historico
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public DateOnly DataAbertura { get; private set; }
    public bool Status { get; private set; }
}