using PetCore.Domain.Enums;

namespace PetCore.Domain.Commons;

public class UsuarioBase
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Nome { get; private set; }
    public DateOnly DataNascimento { get; private set; }
    public string Telefone { get; private set; }
    public string Email{ get; private set; }
    
    public GeneroSexoEnum Sexo { get; private set; }
    public string Senha { get; set; }
    
    public string UrlImg { get; set; }
}