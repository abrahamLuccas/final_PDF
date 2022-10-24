namespace pdf_final.Models
{
    public class TipoCurso
    {
        public int TipoCursoId { get; set; }

        public string Tipo { get; set; }

        public ICollection<FormacaoAcademica> FormacoesAcademicas { get; set; }
    }
}
