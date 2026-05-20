using PetCore.Domain.Entities;

namespace PetCore.Infrastructure.Persistence.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

/// <summary>
/// Mapeamento Fluent API da entidade <see cref="Tutor"/>.
/// </summary>
public class TutorConfiguration : IEntityTypeConfiguration<Tutor>
{
    /// <summary>
    /// Configura colunas, índice único e FKs de avaliação.
    /// </summary>
    public void Configure(EntityTypeBuilder<Tutor> builder)
    {
        // Nome da tabela de avaliações.
        builder.ToTable("tutor_petcore");

        // Chave primária.
        builder.HasKey(x => x.Id);

        // Atributos
        builder.Property(x => x.Nome)
            .IsRequired();
        
        builder.Property(x => x.DataNascimento)
            .IsRequired();
        
        builder.Property(x => x.Telefone)
            .IsRequired();
        
        builder.Property(x => x.Email)
            .IsRequired();
        
        builder.Property(x => x.Sexo)
            .IsRequired();
        
        builder.Property(x => x.Senha)
            .IsRequired();
        
        builder.Property(x => x.UrlImg)
            .IsRequired();
        
        /*
        // Chaves estrangeiras
        builder.Property(x => x.IdPets)
            .IsRequired();

        // Relacionamento com PET (N:N).

        builder.HasOne<User>()
            .WithMany(x => x.Ratings)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);
            */
    }
}