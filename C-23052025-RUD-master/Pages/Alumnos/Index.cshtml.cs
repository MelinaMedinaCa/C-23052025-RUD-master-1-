using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using c_23052025_Rud.Models;
using C_23052025_RUD.Data;
using C_23052025_RUD.Services;

namespace C_23052025_RUD.Pages.Alumnos
{
    public class IndexModel : PageModel
    {
        public List<Alumno> Alumno { get; set; }

        public void OnGet()
        {
            Alumno = ServicioAlumno.obtenerAlumno();
        }
    }
}
