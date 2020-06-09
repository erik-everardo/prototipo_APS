using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PrototipoAPS.Pages.Dashboard
{
    public class Index : PageModel
    {
        public IActionResult OnGet()
        {
            return RedirectToPage("/login");
        }

        public IActionResult OnPost(string username, string password)
        {
            if (username == null || password == null) return RedirectToPage("/login");
            ViewData["username"] = username;
            return Page();
        }
    }
}