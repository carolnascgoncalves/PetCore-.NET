using PetCore.Domain.Entities;

namespace PetCore.Application.DTOs;

public class HistoricoResponse
{
    public DateOnly DataAbertura { get;  set; }
    public bool? Status { get;  set; }

    public HistoricoResponse(Historico historico)
    {
        DataAbertura = historico.DataAbertura;
        Status = historico.Status;
    }
}