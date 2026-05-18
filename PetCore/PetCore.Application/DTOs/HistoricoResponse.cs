using PetCore.Domain.Entities;

namespace PetCore.Application.DTOs;

public class HistoricoResponse
{
    public Guid Id { get; set; }
    public bool Status { get; set; }
    public List<Guid> IdProntuarios { get; set; }
    public Guid IdPet { get; set; }

    public HistoricoResponse(Historico historico)
    {
        Id = historico.Id;
        Status = historico.Status;
        IdProntuarios = historico.IdProntuarios;
        IdPet = historico.IdPet;
    }
}