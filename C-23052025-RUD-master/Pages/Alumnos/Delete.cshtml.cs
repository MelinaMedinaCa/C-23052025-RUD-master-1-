using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using C_23052025_RUD.Models;
using C_23052025_RUD.Rud.Data;



namespace C_23052025_RUD.Pages.Alumnos
{
    public class DeleteModel : PageModel
    {
         [BindProperty]
        public Alumno Alumno { get; set; }
    {
        public void OnGet(int id)
        {
            {
                foreach (var c in DatosCompartidos.Carreras)
                {
                    if (c.Id == id)
                    {
                        Carrera = c;
                        break;
                    }
                }
            }
        public IActionResult OnPost()
        {
            Carrera Alumno AEliminar = null;
            foreach (var c in DatosCompartidos.Alumno)
            {
                if (c.Id == Alumno.Id)
                {
                    AlumnoAEliminar = c;
                    break;
                }
            }
            if (AlumnoAEliminar != null)
            {
                DatosCompartidos.Alumno.Remove(AlumnoAEliminar);
            }
            return RedirectToPage("index");
        }
    }
}
}