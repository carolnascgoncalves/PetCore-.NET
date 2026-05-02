using System.ComponentModel.DataAnnotations;

namespace PetCore.Application.DTOs;

public class ProntuarioRequest
{
    [Required(ErrorMessage = "O campo 'Validade' deve ser preenchido")]
    public DateOnly DataEmissao { get;  set; }
    
    public string Descricao { get;  set; }
    
    [Required(ErrorMessage = "O campo 'IdPetVinculado' deve ser preenchido")]
    public Guid IdPetVinculado { get; set; }
    
    [Required(ErrorMessage = "O campo 'IdTutorResponsavel' deve ser preenchido")]
    public Guid IdTutorResponsavel { get; set; }
    
    [Required(ErrorMessage = "O campo 'IdHistoricoPertencente' deve ser preenchido")]
    public Guid IdHistoricoPertencente { get; set; }
    
    [Required(ErrorMessage = "O campo 'IdMedicoResponsavel' deve ser preenchido")]
    public Guid IdMedicoResponsavel { get; set; }
}