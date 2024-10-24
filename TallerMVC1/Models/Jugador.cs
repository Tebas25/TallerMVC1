﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerMVC1.Models{
    public class Jugador{
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Posicion { get; set; }
        [Required]
        public int Edad { get; set; }
        [ForeignKey("Equipos")]
        public Equipos? Equipo { get; set; }
        public int idEquipo { get; set; }
    }
}
