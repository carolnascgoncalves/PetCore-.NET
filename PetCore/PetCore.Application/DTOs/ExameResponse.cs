using PetCore.Domain.Entities;

namespace PetCore.Application.DTOs;

public class ExameResponse
{
    public Guid Id { get;  set; }
    public string Nome { get;  set; } = string.Empty;
    public bool? Ativo { get;  set; }
    public DateOnly Data { get;  set; }
    public string TipoExame { get;  set; } = string.Empty;
    public Guid IdMedicoResponsavel { get; set; }
    public Guid IdPetVinculado { get; set; }

    public ExameResponse(Exame exame) {
        Id = exame.Id;
        Nome = exame.Nome;
        Ativo = exame.Ativo;
        Data = exame.Data;
        TipoExame = exame.TipoExame;
        IdMedicoResponsavel = exame.IdMedicoResponsavel;
        IdPetVinculado = exame.IdPetVinculado;
    }
}