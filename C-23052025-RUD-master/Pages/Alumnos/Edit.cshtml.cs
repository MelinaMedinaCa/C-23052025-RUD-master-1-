using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using C_23052025_RUD.Models;
using C_23052025_RUD.Data;

namespace C_23052025_RUD.Pages.Alumnos
{
    public class EditModel : PageModel
    {
      
        
            [BindProperty]

            public Alumnos Alumno { get; set; }

        public void OnGet(int id)
        {
            foreach (var c in DatosCompartidos.Alumno)
            {
                if (c.Id == id)
                {
                    Alumno = c;
                    break;
                }
            }
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            foreach (var c in DatosCompartidos.Alumno)
            {
                if (c.Id == Carrera.Id)
                {
                    c.Nombre = Alumno.Nombre;
                    c.Modalidad = Alumno.Modalidad;
                    c.Duracionaños = Alumno.Duracionaños;
                    c.Titulootorgado = Alumno.Titulootorgado;
                    break;
                }
            }
            return RedirectToPage("index");
        }
    }
}
        
    

