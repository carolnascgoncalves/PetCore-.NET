namespace PetCore.Domain.Entities;

public class Protocolo
{
    public string Id { get; private set; }
    public string Titulo { get; private set; }
    public string Texto { get; private set; }
    private Protocolo() { }
    public Protocolo(string id, string titulo, string texto)
    {
        if (string.IsNullOrWhiteSpace(id)) throw new Exception("Id do protocolo está vazio");
        Id = id.Trim().ToUpperInvariant();
        Update(titulo, texto);
    }
    public void Update(string titulo, string texto)
    {
        if (string.IsNullOrWhiteSpace(titulo)) throw new Exception("Título do protocolo está vazio");
        if (string.IsNullOrWhiteSpace(texto)) throw new Exception("Texto do protocolo está vazio");
        Titulo = titulo.Trim();
        Texto = texto.Trim();
    }
}
