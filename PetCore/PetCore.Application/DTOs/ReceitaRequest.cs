using System.ComponentModel.DataAnnotations;

namespace PetCore.Application.DTOs;

public class ReceitaRequest
{
    [Required(ErrorMessage = "O campo 'Nome' deve ser preenchido")]
    [StringLength(150, MinimumLength = 2, ErrorMessage = "Nome deve ter entre 2 à 150 caracteres")]
    public string Nome { get; set; }
    
    [Required(ErrorMessage = "O campo 'Validade' deve ser preenchido")]
    public DateOnly Validade { get; set; }
    
    [Required(ErrorMessage = "O campo 'IdMedico' deve ser preenchido")]
    public Guid IdMedicoResponsavel { get; set; }
    
    [Required(ErrorMessage = "O campo 'Id Medicamentos' deve ser preenchido")]
    public List<Guid> IdMedicamentos { get; set; }
}