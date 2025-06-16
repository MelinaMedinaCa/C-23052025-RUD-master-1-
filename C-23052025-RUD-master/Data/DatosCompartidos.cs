using C_23052025_RUD.Models;
using C_23052025_RUD.Servicios;

namespace C_23052025_RUD.Data
{
    public class DatosCompartidos
    {
        public static List<Carrera> Carreras { get; set; } = new();
       // public static List<Alumnos> Alumno { get; set; } = new();
        private static int ultimoId = 0;

        public static int ObtenerNuevoId()
        {
            ultimoId++;
        return ultimoId; 
        }
        
    }


}
