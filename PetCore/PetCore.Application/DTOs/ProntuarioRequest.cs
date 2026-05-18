using System.ComponentModel.DataAnnotations;

namespace PetCore.Application.DTOs;

public class ProntuarioRequest
{
    [Required(ErrorMessage = "O campo 'Data' deve ser preenchido")]
    public DateOnly DataEmissao { get;  set; }
    
    [Required(ErrorMessage = "O campo 'Descricao' deve ser preenchido")]
    [StringLength(300, MinimumLength = 2, ErrorMessage = "Nome deve ter entre 2 à 300 caracteres")]
    public string Descricao { get;  set; }

    [Required(ErrorMessage = "O campo 'IdMedico' deve ser preenchido")]
    public Guid IdMedico { get; set; }
    
    [Required(ErrorMessage = "O campo 'IdHistorico' deve ser preenchido")]
    public Guid IdHistorico { get; set; }
    
    [Required(ErrorMessage = "O campo 'IdExames' deve ser preenchido")]
    public List<Guid> IdExames { get; set; }
    
    [Required(ErrorMessage = "O campo 'IdReceitas' deve ser preenchido")]
    public List<Guid> IdReceitas { get; set; }
}