using System.ComponentModel.DataAnnotations;

namespace PetCore.Application.DTOs;

/// <summary>
/// Cadastro de Relatorio
/// </summary>
public class RelatorioRequest
{
    [Required(ErrorMessage = "O campo 'Observacao' deve ser preenchido")]
    [StringLength(500, MinimumLength = 2, ErrorMessage = "Nome deve ter entre 2 à 500 caracteres")]
    public string Observacao { get; set; }
    
    [Required(ErrorMessage = "O campo 'IdMedico' deve ser preenchido")]
    public Guid IdMedico { get; set; }
    
    [Required(ErrorMessage = "O campo 'IdHistorico' deve ser preenchido")]
    public Guid IdHistorico { get; set; }
}