using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PrototipoAPS.Pages.Dashboard
{
    public class AltasBajasCambiosMaestros : PageModel
    {
        public string what;
        public void OnGet(string username, string accion)
        {
            ViewData["username"] = username;
            what = accion;
        }
    }
}