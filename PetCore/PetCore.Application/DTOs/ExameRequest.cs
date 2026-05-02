using System.ComponentModel.DataAnnotations;

namespace PetCore.Application.DTOs;

public class ExameRequest
{
    [Required(ErrorMessage = "O campo 'Nome' deve ser preenchido")]
    [StringLength(150, MinimumLength = 2, ErrorMessage = "Nome deve ter entre 2 à 150 caracteres")]
    public string Nome { get;  set; }
    
    public bool? Ativo { get;  set; }
    
    [Required(ErrorMessage = "O campo 'Data' deve ser preenchido")]
    public DateOnly Data { get;  set; }
    
    [Required(ErrorMessage = "O campo 'Tipo do Exame' deve ser preenchido")]
    [StringLength(150, MinimumLength = 2, ErrorMessage = "Tipo do Exame deve ter entre 2 à 150 caracteres")]
    public string TipoExame { get;  set; }

    [Required(ErrorMessage = "O campo 'IdTutorResponsavel' deve ser preenchido")]
    public Guid IdMedicoResponsavel { get; set; }
    
    [Required(ErrorMessage = "O campo 'IdTutorResponsavel' deve ser preenchido")]
    public Guid IdPetVinculado { get; set; }
}