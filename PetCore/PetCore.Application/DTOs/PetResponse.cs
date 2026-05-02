using PetCore.Domain.Entities;
using PetCore.Domain.Enums;

namespace PetCore.Application.DTOs;

public class PetResponse
{
    public Guid Id { get;  set; }
    public string Nome { get;  set; } = String.Empty;
    public string Especie { get;  set; } = String.Empty;
    public string Raca { get;  set; } = String.Empty;
    public DateOnly DataNasc { get;  set; }
    public string Pelagem { get;  set; } = String.Empty;
    public string Porte { get;  set; } = String.Empty;
    public GeneroSexoEnum Sexo { get;  set; }
    public bool? Status { get;  set; }
    public Guid IdHistorico { get; set; }
    public List<Guid> IdTutores { get; set; }

    public PetResponse(Pet pet)
    {
        Id = pet.Id;
        Nome = pet.Nome;
        Especie = pet.Especie;
        Raca = pet.Raca;
        DataNasc = pet.DataNasc;
        Pelagem = pet.Pelagem;
        Porte = pet.Porte;
        Sexo = pet.Sexo;
        Status = pet.Status; 
        IdHistorico = pet.IdHistorico;
        IdTutores = pet.IdTutores;
        IdTutores = pet.IdTutores;
    }
}