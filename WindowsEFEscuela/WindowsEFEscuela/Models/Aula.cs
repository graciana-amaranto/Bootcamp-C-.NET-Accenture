using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Aula")]
    public class Aula
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="int")]
        [Required]
        public int Capacidad { get; set; }

        [Column(TypeName ="char")]
        [StringLength(1)]
        [Required]
        public string Codigo { get; set; }

    }
}
