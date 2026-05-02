using System.ComponentModel.DataAnnotations;

namespace PetCore.Application.DTOs;

/// <summary>
/// Cadastro de Relatorio
/// </summary>
public class RelatorioRequest
{
    [Required(ErrorMessage = "O campo 'IdMedico' deve ser preenchido")]
    public Guid IdMedico { get; set; }
    
    [Required(ErrorMessage = "O campo 'IdHistorico' deve ser preenchido")]
    public Guid IdHistorico { get; set; }
}