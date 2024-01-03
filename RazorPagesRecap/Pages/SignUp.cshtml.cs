using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesRecap.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public string? Username { get; set; }
        [BindProperty]
        public string? Password { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Skicka anv�ndarnamnet och l�senordet till "Congratulations"-sidan

            return RedirectToPage("/Congratulations", new { Username, Password });
        }
    }
}

