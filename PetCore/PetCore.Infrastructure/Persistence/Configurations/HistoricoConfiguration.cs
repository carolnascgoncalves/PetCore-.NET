namespace PetCore.Infrastructure.Persistence.Configurations;
using PetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class HistoricoConfiguration : IEntityTypeConfiguration<Historico>
{
    public void Configure(EntityTypeBuilder<Historico> builder)
    {
        // Nome da tabela de avaliações.
        builder.ToTable("relatorio_petcore");

        // Chave primária.
        builder.HasKey(x => x.Id);

        // Atributos
        builder.Property(x => x.DataAbertura)
            .IsRequired();
        
        builder.Property(x => x.Status)
            .IsRequired();

        
        // RELACIONAMENTOS
        //1:N Relatorios (RelatorioConfiguration)
      
        
        //1:1 Pet (PetConfiguration)

        
        //1:N Prontuario (ProntuarioConfiguration)
        
    }
}