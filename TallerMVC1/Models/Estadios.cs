using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TallerMVC1.Models{
    public class Estadios{
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Direccion {  get; set; }
        [Required]
        [AllowNull]
        public int capacidad { get; set; }
    }
}
