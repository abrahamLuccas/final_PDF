using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pdf_final.Models;

namespace pdf_final.Mapeamento
{
    public class ObjetivoMap : IEntityTypeConfiguration<Objetivo>
    {
        public void Configure(EntityTypeBuilder<Objetivo> builder)
        {
            builder.HasKey(o => o.ObjetivoId);

            builder.Property(o => o.Descricao).IsRequired().HasMaxLength(1000);

            builder.HasOne(o => o.Curriculo).WithMany(o => o.Objetivos).HasForeignKey(o => o.CurriculoId);

            builder.ToTable("Objetivos");
        }
    }
}
