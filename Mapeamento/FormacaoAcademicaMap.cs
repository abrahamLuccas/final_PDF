using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pdf_final.Models;

namespace pdf_final.Mapeamento
{
    public class FormacaoAcademicaMap : IEntityTypeConfiguration<FormacaoAcademica>
    {
        public void Configure(EntityTypeBuilder<FormacaoAcademica> builder)
        {
            builder.HasKey(f => f.FormacaoAcademicaId);

            builder.Property(f => f.Instituicao).IsRequired().HasMaxLength(50);
            builder.Property(f => f.AnoInicio).IsRequired();
            builder.Property(f => f.AnoFim).IsRequired();
            builder.Property(f => f.NomeCurso).IsRequired().HasMaxLength(50);

            builder.HasOne(f => f.TipoCurso).WithMany(f => f.FormacoesAcademicas).HasForeignKey(f => f.TipoCursoId);
            builder.HasOne(f => f.Curriculo).WithMany(f => f.FormacoesAcademicas).HasForeignKey(f => f.CurriculoId);

            builder.ToTable("FormacoesAcademicas");
        }
    }
}
