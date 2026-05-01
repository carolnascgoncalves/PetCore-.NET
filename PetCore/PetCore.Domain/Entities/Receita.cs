using PetCore.Domain.Commons;

namespace PetCore.Domain.Entities;

public class Receita : DocumentoBase
{
    public DateOnly Validade { get; private set; }
    public Medico MedicoResponsavel { get; private set; }
    public Pet PetVinculado { get; private set; }
    
    // N:N medicamento
    public List<Medicamento> Medicamentos { get; set; }
}