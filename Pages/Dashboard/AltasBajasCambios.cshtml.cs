using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PrototipoAPS.Pages.Dashboard
{
    public class AltasBajasCambios : PageModel
    {
        public string what;
        public void OnGet(string accion, string username)
        {
            ViewData["username"] = username;
            what = accion;
        }
    }
}