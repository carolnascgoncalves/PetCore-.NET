using PetCore.Domain.Enums;

namespace PetCore.Domain.Commons;

public class UsuarioBase
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Nome { get;  set; }
    public DateOnly DataNascimento { get;  set; }
    public string Telefone { get;  set; }
    public string Email{ get;  set; }
    
    public GeneroSexoEnum Sexo { get;  set; }
    
    public string Senha { get; set; }
    
    public string UrlImg { get; set; }
}