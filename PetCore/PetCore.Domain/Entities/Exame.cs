using PetCore.Domain.Commons;

namespace PetCore.Domain.Entities;

public class Exame : DocumentoBase
{
    public DateOnly Data { get; private set; }
    public String Tipo { get; private set; }

    //N:1 Medico
    public Guid IdMedico { get; set; }
    public Guid IdProntuario { get; set; }
    
}