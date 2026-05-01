namespace PetCore.Domain.Entities;

public class Clinica
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; private set; }
    public string Cnpj { get; private set; }
    
    //1:1 Endereco
    public Endereco Endereco { get; private set; }
}