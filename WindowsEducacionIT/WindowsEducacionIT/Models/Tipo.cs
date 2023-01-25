using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEducionIT.Models
{
    [Table("Tipo")]
    public class Tipo
    {
        [Key]
        public int IdTipo { get; set; }
        [Column(TypeName ="varchar"), StringLength(50), Required]
        public string Nombre { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }
    }
}