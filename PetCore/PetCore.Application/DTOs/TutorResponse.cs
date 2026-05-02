using PetCore.Domain.Entities;
using PetCore.Domain.Enums;

namespace PetCore.Application.DTOs;

public class TutorResponse
{
    public Guid Id { get;  set; }
    public string Nome { get;  set; }
    public DateOnly DataNascimento { get;  set; }
    public string Telefone { get;  set; }
    public string Email{ get;  set; }
    public GeneroSexoEnum GeneroSexo { get;  set; }
    public string Senha { get; set; }
    public List<Guid> IdPets { get; set; }

    public TutorResponse(Tutor tutor)
    {
        Id = tutor.Id;
        Nome = tutor.Nome;
        DataNascimento = tutor.DataNascimento;
        Telefone = tutor.Telefone;
        Email = tutor.Email;
        GeneroSexo = tutor.GeneroSexo;
        Senha = tutor.Senha;
        IdPets = tutor.IdPets;
    }
}