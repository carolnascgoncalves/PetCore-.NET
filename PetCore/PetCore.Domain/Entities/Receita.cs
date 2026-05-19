using PetCore.Domain.Commons;

namespace PetCore.Domain.Entities;

public class Receita : DocumentoBase
{
    public DateOnly Validade { get; private set; }
    public Guid IdMedicoResponsavel { get; private set; }
    public Guid IdProntuario { get; private set; }
    
    // N:N medicamento
    public List<Guid> IdMedicamentos { get; set; }

    public Receita(String nome, DateOnly validade, Guid idMedicoResponsavel, List<Guid> idMedicamentos)
    {
        if (string.IsNullOrEmpty(nome))
            throw new Exception("Nome está vazio");
        Nome = nome;

        if (validade.Year > DateTime.Now.Year || validade.Equals(null))
            throw new Exception("Validade inválida");
        Validade = validade;
        
        if (IdMedicoResponsavel == Guid.Empty)
            throw new Exception("Id do Médico está vazio");
        IdMedicoResponsavel = idMedicoResponsavel;

        if (idMedicamentos == null || !idMedicamentos.Any())
            throw new Exception("Lista de medicamentos está vazia");
        IdMedicamentos = idMedicamentos;
    }
}