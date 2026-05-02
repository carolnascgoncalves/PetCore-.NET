using System.ComponentModel.DataAnnotations;

namespace PetCore.Application.DTOs;

public class HistoricoRequest
{
    [Required(ErrorMessage = "O campo 'Data de Abertura' deve ser preenchido")]
    public DateOnly DataAbertura { get;  set; }
    
    public bool? Status { get;  set; }
}