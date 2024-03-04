using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GatoImposible.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; } // Clave primaria
        [Required]
        public string Username { get; set; } // Username único
        [Required]
        public string Password { get; set; } // Contraseña
        [Column(TypeName ="VARCHAR(MAX)")]
        public string FotoPerfil { get; set; } // Ruta o base64 de la foto de perfil
        public virtual ICollection<Partida> Partidas { get; set; } // Relación uno a muchos
    }
}
