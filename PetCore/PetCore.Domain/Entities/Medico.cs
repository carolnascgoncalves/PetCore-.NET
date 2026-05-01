using PetCore.Domain.Commons;

namespace PetCore.Domain.Entities;

public class Medico : UsuarioBase
{
    public string Especialidade { get; private set; }
}