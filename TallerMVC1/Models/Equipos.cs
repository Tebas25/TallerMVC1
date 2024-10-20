using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerMVC1.Models{
    public class Equipos{
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Required]
        public string Ciudad { get; set; }
        [Required]
        public int Titulos { get; set; }
        [Required]
        public bool AceptaExtranjeros {  get; set; }
        public Estadios Estadio {  get; set; }
        [ForeignKey("Estadios")]
        public int idEstadio { get; set; }
    }
}
