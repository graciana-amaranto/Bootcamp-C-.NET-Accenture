using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionIT.Models
{
    [Table("Detalle")]
    public class Detalle
    {
        [Key]
        public int IdDetalle { get; set; }
        public int IdEstado { get; set; }
        [ForeignKey("IdEstado")]
        private Estado Estado { get; set; }
        public int IdPlanilla { get; set; }
        [ForeignKey("IdPlanilla")]
        private Planilla Planilla { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }
    }
}
