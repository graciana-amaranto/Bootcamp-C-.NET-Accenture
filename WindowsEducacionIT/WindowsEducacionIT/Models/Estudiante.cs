using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEducionIT.Models
{
    [Table("Estudiante")]
    public class Estudiante
    {
        [Key]
        public int IdEstudiante { get; set; }
        public int IdLocalidad { get; set; }
        [ForeignKey("IdLocalidad")]
        private Localidad Localidad { get; set; }
        [Column(TypeName = "varchar"), StringLength(50), Required]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar"), StringLength(50), Required]
        public string Apellido { get; set; }
        [Column(TypeName = "varchar"), StringLength(50), Required]
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
    }
}