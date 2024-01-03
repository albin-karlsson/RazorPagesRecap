using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesRecap.Pages
{
    public class CongratulationsModel : PageModel
    {
        public string? Username { get; set; }
        public string? Password { get; set; }

        public void OnGet(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
