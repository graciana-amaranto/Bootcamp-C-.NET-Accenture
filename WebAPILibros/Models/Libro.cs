using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPILibros.Models
{
    [Table("Libro")]
    public class Libro
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Titulo { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Descripcion { get; set; }
        
        [ForeignKey("AutorId")]
        public int AutorId { get; set; }

        public Autor Autor { get; set; }


    }
    }
