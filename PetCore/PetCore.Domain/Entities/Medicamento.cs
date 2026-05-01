using PetCore.Domain.Commons;

namespace PetCore.Domain.Entities;

public class Medicamento : DocumentoBase
{
    public string Dosagem { get; private set; }
    public string Instrucao { get; private set; }
}