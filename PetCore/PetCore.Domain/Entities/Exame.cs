using PetCore.Domain.Commons;

namespace PetCore.Domain.Entities;

public class Exame : DocumentoBase
{
    public DateOnly Data { get; private set; }
    public string TipoExame { get; private set; }

    //N:1 Medico
    public Guid IdMedicoResponsavel { get; set; }
    public Guid IdPetVinculado { get; set; }
    
}