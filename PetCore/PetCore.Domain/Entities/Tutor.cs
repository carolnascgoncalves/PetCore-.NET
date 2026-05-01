using PetCore.Domain.Commons;

namespace PetCore.Domain.Entities;

public class Tutor : UsuarioBase
{
    //N:N Pets
    public List<Pet> Pets { get; set; }
}