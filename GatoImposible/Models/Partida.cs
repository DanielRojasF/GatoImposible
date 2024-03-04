using System.ComponentModel.DataAnnotations;

namespace GatoImposible.Models
{
    public class Partida
    {
        [Key]
        public int PartidaId { get; set; } // Clave primaria
        [Required]
        public Usuario Usuario { get; set; } // Clave foránea de Usuario
        [Required]
        public string Resultado { get; set; } // Resultado de la partida (Empate o Pérdida)
        [Required]
        public TimeSpan Duracion { get; set; } // Duración de la partida
    }
}
