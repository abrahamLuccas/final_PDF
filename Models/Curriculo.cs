namespace pdf_final.Models
{
    public class Curriculo
    {
            public int CurriculoId { get; set; }

            public string Nome { get; set; }                                 

            public ICollection<Objetivo> Objetivos { get; set; }

            public ICollection<FormacaoAcademica> FormacoesAcademicas { get; set; }

            public ICollection<ExperienciaProfissional> ExperienciasProfissionais { get; set; }

            public ICollection<Idioma> Idiomas { get; set; }
    }
}
