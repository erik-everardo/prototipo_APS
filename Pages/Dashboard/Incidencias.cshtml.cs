using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PrototipoAPS.Pages.Dashboard
{
    public class Incidencias : PageModel
    {
        public void OnGet(string username)
        {
            ViewData["username"] = username;
        }
    }
}