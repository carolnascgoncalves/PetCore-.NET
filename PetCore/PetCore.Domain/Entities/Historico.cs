namespace PetCore.Domain.Entities;

public class Historico
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    
    public DateOnly DataAbertura { get; private set; }
    
    public bool Status { get; private set; }
    
    public Guid IdPet { get; private set; }
    
    public List<Guid> IdRelatorios { get; private set; }
    
    public List<Guid> IdProntuarios { get; private set; }

    public Historico(DateOnly data, Guid idPet, List<Guid> idProntuarios)
    {
        if (data.Year > DateTime.Now.Year || data.Equals(null))
            throw new Exception("Data inválida");
        DataAbertura = data;

        if (idPet == Guid.Empty)
            throw new Exception("Id do pet inválido");
        IdPet = idPet;
        
        if (idProntuarios == null || !idProntuarios.Any())
            throw new Exception("Lista de prontuarios está vazia");
        IdProntuarios = idProntuarios;
    }
    
}