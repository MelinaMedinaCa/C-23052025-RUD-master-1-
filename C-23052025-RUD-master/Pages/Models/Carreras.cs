using System.ComponentModel.DataAnnotations;
using C_23052025_RUD.Servicios;

namespace C_23052025_RUD.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public int Duracionaños { get; set; }
        [Required]
        public string? Titulootorgado { get; set; }
        [Required]
        public string? Modalidad { get; set; } // Ej: Presencia, virtual, hibrida
    }
}
