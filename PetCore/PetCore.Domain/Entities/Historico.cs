namespace PetCore.Domain.Entities;

public class Historico
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    
    public DateOnly DataAbertura { get; private set; }
    
    public bool Status { get; private set; }
    
    //RELACIONAMENTOS
    public List<Relatorio> Relatorios { get; private set; }
    
    public List<Prontuario> Prontuarios { get; private set; }
    
    public Pet Pet { get; private set; }
    
    

    public Historico(DateOnly data)
    {
        if (data.Year > DateTime.Now.Year || data.Equals(null))
            throw new Exception("Data inválida");
        DataAbertura = data;

        Status = true;
    }
    
}