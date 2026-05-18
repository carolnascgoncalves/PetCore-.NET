using PetCore.Domain.Commons;

namespace PetCore.Domain.Entities;

public class Receita : DocumentoBase
{
    public DateOnly Validade { get; private set; }
    public Guid IdMedicoResponsavel { get; private set; }
    public Guid IdProntuario { get; private set; }
    
    // N:N medicamento
    public List<Guid> IdMedicamentos { get; set; }
}