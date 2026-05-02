using PetCore.Domain.Entities;
using PetCore.Domain.Enums;

namespace PetCore.Application.DTOs;

public class MedicoResponse
{
    public Guid Id { get;  set; } 
    public string Nome { get;  set; } = String.Empty;
    public DateOnly DataNascimento { get;  set; }
    public string Telefone { get;  set; } = String.Empty;
    public string Email{ get;  set; } = String.Empty;
    public GeneroSexoEnum GeneroSexo { get;  set; }
    public string Senha { get; set; } = String.Empty;
    public string Especialidade { get;  set; } = String.Empty;

    public MedicoResponse(Medico medico)
    {
        Id = medico.Id;
        Nome = medico.Nome;
        DataNascimento = medico.DataNascimento;
        Telefone = medico.Telefone;
        Email = medico.Email;
        GeneroSexo = medico.GeneroSexo;
        Senha = medico.Senha;
        Especialidade = medico.Especialidade;
    }
}