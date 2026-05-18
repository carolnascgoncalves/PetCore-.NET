using PetCore.Domain.Entities;

namespace PetCore.Application.Interfaces;

public interface IPetRepository
{
    void Create(Pet pet);
    void UpdateStatus(Pet pet);
    void UpdateImage(Pet pet);
    void DeleteImage(Pet pet);
    IReadOnlyCollection<Pet> FetchAll();
    IReadOnlyCollection<Pet> FetchMenuAll();
    Pet? FetchById(Guid id);
}