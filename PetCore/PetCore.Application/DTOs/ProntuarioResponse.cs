using PetCore.Domain.Entities;

namespace PetCore.Application.DTOs;

public class ProntuarioResponse
{
    public Guid Id { get;  set; }
    public DateOnly DataEmissao { get;  set; }
    public string Descricao { get; set; } = String.Empty;
    public Guid IdPetVinculado { get; set; }
    public Guid IdTutorResponsavel { get; set; }
    public Guid IdHistoricoPertencente { get; set; }
    public Guid IdMedicoResponsavel { get; set; }

    public ProntuarioResponse(Prontuario prontuario)
    {
        Id = prontuario.Id;
        DataEmissao = prontuario.DataEmissao;
        Descricao = prontuario.Descricao;
        IdPetVinculado = prontuario.IdPetVinculado;
        IdTutorResponsavel = prontuario.IdTutorResponsavel;
        IdHistoricoPertencente = prontuario.IdHistoricoPertencente;
        IdMedicoResponsavel = prontuario.IdMedicoResponsavel;
    }
}