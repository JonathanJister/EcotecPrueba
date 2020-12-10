using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EvaluacionEcotec.Model
{
    public class Contacto
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(MAX)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "varchar(25)")]
        public string Telefono { get; set; }

        [Required]
        [Column(TypeName = "Varchar(15)")]
        public string Fecha { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Direccion { get; set; }
    }
}
