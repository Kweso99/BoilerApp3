using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace BoilerApp.Pages
{
    public class IndexModel : PageModel
    {
        private const string CorrectPassword = "yourPassword"; 

        [BindProperty]
        public string Password { get; set; }

        public bool LoginFailed { get; set; }

        public void OnGet()
        {
            LoginFailed = false;
        }

        public IActionResult OnPost()
        {
            if (Password == CorrectPassword)
            {
                
                HttpContext.Session.SetString("IsLoggedIn", "true");
                return RedirectToPage("/Menu");
            }
            else
            {
                LoginFailed = true;
                return Page();
            }
        }
    }
}
