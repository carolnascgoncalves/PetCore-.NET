using PetCore.Application.DTOs;

namespace PetCore.Application.Services.Interfaces;

public interface IExameService
{
    IReadOnlyCollection<ExameResponse> FetchAll();
    
    ExameResponse? FetchById(Guid id);
    
    ExameResponse Create(ExameRequest request);
    
    ExameResponse Update(Guid id, ExameDadosRequest request);
    
    bool Delete(Guid id);
}