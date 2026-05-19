using System.ComponentModel.DataAnnotations;
using PetCore.Domain.Entities;

namespace PetCore.Application.DTOs;

public class HistoricoRequest
{
    [Required(ErrorMessage = "O campo 'Data' deve ser preenchido")]
    public DateOnly Data { get; set; }

    public bool Status { get; set; } = true;

    [Required(ErrorMessage = "O campo 'Id do(s) Prontuario(s)' deve ser preenchido")]
    public List<Guid> IdProntuarios { get; set; }
    
    [Required(ErrorMessage = "O campo 'Id do Pet' deve ser preenchido")]
    public Guid IdPet { get; set; }
    
    public Historico ToDomain() =>
        new(Data,IdPet,IdProntuarios);
}