namespace PetCore.Domain.Entities;

public class Endereco
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Cep { get; set; }
    public string Complemento { get; set; }
}