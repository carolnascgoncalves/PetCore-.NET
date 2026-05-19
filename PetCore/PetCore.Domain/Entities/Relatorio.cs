namespace PetCore.Domain.Entities;

public class Relatorio
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public string Observacao { get; set; } 
    
    //N:1 Historico
    public Guid IdHistorico { get; set; }
    //N:1 Medico
    public Guid IdMedicoResponsavel { get; set; }
    
    public List<Guid> IdClinicas { get; set; }


    public Relatorio(string observacao, Guid idHistorico, Guid idMedicoResponsavel, List<Guid> idClinicas)
    {
        UpdateObs(observacao);

        if (IdHistorico == Guid.Empty) 
            throw new Exception("Id do historico está vazio");
        IdHistorico = idHistorico;

        if (IdMedicoResponsavel == Guid.Empty)
            throw new Exception("Id do Médico está vazio");
        IdMedicoResponsavel = idMedicoResponsavel;
        
        if (idClinicas == null || !idClinicas.Any())
            throw new Exception("Lista de clinicas está vazia");
        IdClinicas = idClinicas;
    }

    public void UpdateObs(string observacao)
    {
        if (string.IsNullOrWhiteSpace(observacao))
            throw new Exception("Observação está vazia");

        Observacao = observacao.Trim();
    }
    
    public void Update(string observacao)
    {
        UpdateObs(observacao);
    }
    public Relatorio(){}
}