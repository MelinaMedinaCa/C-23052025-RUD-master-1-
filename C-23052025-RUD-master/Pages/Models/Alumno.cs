using System.ComponentModel.DataAnnotations;

namespace C_23052025_RUD.Pages.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public int Fn { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Mail  { get; set; } // Ej: Presencia, virtual, hibrida
    }
}
    