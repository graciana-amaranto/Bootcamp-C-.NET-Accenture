using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEducionIT.Models
{
    [Table("Evaluacion")]
    public class Evaluacion
    {
        [Key]
        public int IdEvaluacion { get; set; }
        public int IdTipo { get; set; }
        [ForeignKey("IdTipo")]
        private Tipo Tipo { get; set; }
        public int IdEstudiante { get; set; }
        [ForeignKey("IdEstudiante")]
        private Estudiante Estudiante { get; set; }
        public int IdDetalle { get; set; }
        [ForeignKey("IdDetalle")]
        private Detalle Detalle { get; set; }
        public int Nota { get; set; }
    }
}