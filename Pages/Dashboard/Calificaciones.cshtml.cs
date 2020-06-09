using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PrototipoAPS.Pages.Dashboard
{
    public class Calificaciones : PageModel
    {
        public string what;
        public void OnGet(string accion, string username)
        {
            what = accion;
            ViewData["username"] = username;
        }
    }
}