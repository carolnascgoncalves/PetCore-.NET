using PetCore.Application.DTOs;

namespace PetCore.Application.Services.Interfaces;

public interface IPetService
{
    PetResponse Create(PetRequest request);
    
    PetResponse UpdateStatus(Guid id, PetStatusRequest request);
    
    PetResponse UpdateImage(Guid id, PetImgRequest request);
    
    void DeleteImage(Guid id);
    
    IReadOnlyCollection<PetResponse> FetchAll();
    
    IReadOnlyCollection<PetMenuResponse> FetchMenuAll();
    
    PetResponse? FetchById(Guid id);
}