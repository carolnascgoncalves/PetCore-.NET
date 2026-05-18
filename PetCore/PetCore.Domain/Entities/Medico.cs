using PetCore.Domain.Commons;

namespace PetCore.Domain.Entities;

public class Medico : UsuarioBase
{
    public string Especialidade { get; private set; }
    
    public List<Guid> IdRelatorios { get; private set; }
    public List<Guid> IdProntuarios { get; private set; }
    public List<Guid> IdExames { get; private set; }
    public List<Guid> IdReceitas { get; private set; }
}