using System.ComponentModel.DataAnnotations;

namespace pdf_final.Models
{
    public class Objetivo
    {
        public int ObjetivoId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Descrição muito longa!")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        public int CurriculoId { get; set; }

        public Curriculo Curriculo { get; set; }
    }
}
