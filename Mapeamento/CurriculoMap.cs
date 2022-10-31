using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pdf_final.Models;

namespace pdf_final.Mapeamento
{
    public class CurriculoMap : IEntityTypeConfiguration<Curriculo>
    {
        public void Configure(EntityTypeBuilder<Curriculo> builder)
        {
            builder.HasKey(c => c.CurriculoId);

            builder.Property(c => c.Nome).IsRequired().HasMaxLength(50);
            builder.HasIndex(c => c.Nome).IsUnique();

            builder.HasMany(c => c.Objetivos).WithOne(c => c.Curriculo).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(c => c.FormacoesAcademicas).WithOne(c => c.Curriculo).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(c => c.ExperienciasProfissionais).WithOne(c => c.Curriculo).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(c => c.Idiomas).WithOne(c => c.Curriculo).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Curriculos");
        }
    }
}
