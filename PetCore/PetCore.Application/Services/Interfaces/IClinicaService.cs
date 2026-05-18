using PetCore.Application.DTOs;

namespace PetCore.Application.Services.Interfaces;

public interface IClinicaService
{
    IReadOnlyCollection<ClinicaResponse> FetchAll();
    
    ClinicaResponse? FetchById(Guid id);
    
    ClinicaResponse Create(ClinicaRequest request);
    
    ClinicaResponse Update(Guid id, ClinicaRequest request);
    
    bool Delete(Guid id);
}