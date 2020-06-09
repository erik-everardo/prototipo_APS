using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting.Internal;

namespace PrototipoAPS.Pages.Dashboard
{
    public class Horarios : PageModel
    {
        public string what;
        public void OnGet(string accion, string username)
        {
            what = accion;
            ViewData["username"] = username;
        }
    }
}