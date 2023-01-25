using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEducionIT.Models
{
    [Table("Localidad")]
    public class Localidad
    {
        [Key]
        public int IdLocalidad { get; set; }
        [Column(TypeName = "varchar"), StringLength(50), Required]
        public string Nombre { get; set; }
        public List<Profesor> Profesores { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
    }
}