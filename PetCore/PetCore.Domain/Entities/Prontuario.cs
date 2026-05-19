namespace PetCore.Domain.Entities;

public class Prontuario
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public DateOnly DataEmissao { get; private set; }
    public string Descricao { get; private set; }
    
    public List<Guid> IdExames { get; private set; }
    
    public List<Guid> IdReceitas { get; private set; }
    
    public Guid IdHistorico { get; private set; }
    //N:1 Medico 
    public Guid IdMedico { get; private set; }

    public Prontuario(DateOnly dataEmissao, string descricao, Guid idMedico, Guid idHistorico, List<Guid> idExames, List<Guid> idReceitas)
    {
        if (dataEmissao.Year > DateTime.Now.Year || dataEmissao.Equals(null))
            throw new Exception("Data de emissão inválida");
        DataEmissao = dataEmissao;

        UpdateDesc(descricao);
        
        if (idMedico == Guid.Empty)
            throw new Exception("Id do Médico está vazio");
        IdMedico = idMedico;
        
        if (idHistorico == Guid.Empty)
            throw new Exception("Id do Historico está vazio");
        IdHistorico = idHistorico;
        
        if (idExames == null || !idExames.Any())
            throw new Exception("Lista de exames está vazia");
        IdExames = idExames;

        if (idReceitas == null || !idReceitas.Any())
            throw new Exception("Lista de receitas está vazia");
        IdReceitas = idReceitas;
    }

    public void UpdateDesc(string descricao)
    {
        if (string.IsNullOrWhiteSpace(descricao))
            throw new Exception("Descrição está vazia");
        Descricao = descricao.Trim();
    }

    public void Update()
    {
        UpdateDesc(Descricao);
    }
}