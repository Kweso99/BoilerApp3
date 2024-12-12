using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BoilerApp;

namespace BoilerApp.Pages
{
    public class DataEntryModel : PageModel
    {
        [BindProperty]
        public double Temperature { get; set; }

        [BindProperty]
        public double Pressure { get; set; }

        public bool DataEntered { get; set; }

        public void OnGet()
        {
            DataEntered = false;
        }

        public IActionResult OnPost()
        {
            // Save the entered data
            BoilerData.AddReading(Temperature, Pressure);
            DataEntered = true;
            return Page();
        }
    }
}

