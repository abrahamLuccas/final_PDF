using Microsoft.EntityFrameworkCore;
using pdf_final.Mapeamento;
using pdf_final.Models;

namespace pdf_final.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Curriculo> Curriculos { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<TipoCurso> TiposCursos { get; set; }
        public DbSet<FormacaoAcademica> FormacoesAcademicas { get; set; }
        public DbSet<ExperienciaProfissional> ExperienciasProfissionais { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<InformacaoLogin> InformacoesLogin { get; set; }

        public DbSet<Objetivo> Objetivos { get; set; }

        // public DbSet<Usuario> Usuarios { get; set; }
        // public DbSet<InformacaoLogin> InformacoesLogin { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CurriculoMap());
            modelBuilder.ApplyConfiguration(new ExperienciaProfissionalMap());
            modelBuilder.ApplyConfiguration(new FormacaoAcademicaMap());
            modelBuilder.ApplyConfiguration(new IdiomaMap());         
            modelBuilder.ApplyConfiguration(new UsuarioMap());         
            modelBuilder.ApplyConfiguration(new InformacaoLoginMap());         
            modelBuilder.ApplyConfiguration(new ObjetivoMap());
            modelBuilder.ApplyConfiguration(new TipoCursoMap());
        }
   
    }
}
