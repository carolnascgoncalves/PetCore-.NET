using PetCore.Domain.Entities;

namespace PetCore.Application.Interfaces;

public interface IReceitaRepository
{
    void Create(Receita receita);
    void Delete(Receita receita);
    IReadOnlyCollection<Receita> FetchAll();
    Receita? FetchById(Guid id);
    void SaveChanges();
}