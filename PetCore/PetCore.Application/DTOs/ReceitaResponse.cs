using PetCore.Domain.Entities;

namespace PetCore.Application.DTOs;

public class ReceitaResponse
{
    public Guid Id { get;  set; }
    public string Nome { get;  set; } = String.Empty;
    public bool? Ativo { get;  set; }
    public DateOnly Validade { get;  set; }
    public Guid IdMedicoResponsavel { get;  set; }
    public Guid IdPetVinculado { get;  set; }
    public List<Guid> Medicamentos { get; set; }

    public ReceitaResponse(Receita receita)
    {
        Id = receita.Id;
        Nome = receita.Nome;
        Ativo = receita.Ativo;
        Validade = receita.Validade;
        IdMedicoResponsavel = receita.IdMedicoResponsavel;
        IdPetVinculado = receita.IdPetVinculado;
        Medicamentos = receita.Medicamentos;
    }
}