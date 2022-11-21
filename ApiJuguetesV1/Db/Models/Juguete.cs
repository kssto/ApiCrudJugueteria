using Db.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Models
{
    public class Juguete:IEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [MaxLength(100)]
        [Required]
        public string Descripcion { get; set; } = string.Empty;
        [Range(0, 100, ErrorMessage = "Ingrese un valor entre 0 y 100")]
        [Required]
        public int RestriccionEdad { get; set; }
        [MaxLength(50)]
        [Required]
        public string Compania { get; set; } = string.Empty;
        [Range(0.0, 1000, ErrorMessage = "Ingrese un valor entre 0 y 1000")]
        [Required]
        public double Precio { get; set; }
    }
}
