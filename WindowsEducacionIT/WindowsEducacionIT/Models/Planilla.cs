using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionIT.Models
{
    [Table("Planilla")]
    public class Planilla
    {
        [Key]
        public int IdPlanilla { get; set; }
        public int IdCarrera { get; set; }
        [ForeignKey("IdCarrera")]
        private Carrera Carrera { get; set; }
        public int IdMateria { get; set; }
        [ForeignKey("IdMateria")]
        private Materia Materia { get; set; }
        public int IdProfesor { get; set; }
        [ForeignKey("IdProfesor")]
        private Profesor Profesor { get; set; }
        public int IdCurso { get; set; }
        [ForeignKey("IdCurso")]
        private Curso Curso { get; set; }
        public List<Detalle> Detalles { get; set; }
        public DateTime Fecha { get; set; }
    }
}
