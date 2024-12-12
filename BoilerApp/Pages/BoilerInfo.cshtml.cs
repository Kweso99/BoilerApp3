using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace BoilerApp.Pages
{
    public class BoilerInfoModel : PageModel
    {
        public string BoilerId { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public double MaxPressure { get; set; }
        public double MaxTemperature { get; set; }

        [BindProperty]
        public string NewPassword { get; set; }

        public bool PasswordChanged { get; set; }

        public void OnGet()
        {
            // Load boiler info (here, using hardcoded values)
            BoilerId = "BOILER123";
            DateOfPurchase = DateTime.Parse("2020-01-01");
            MaxPressure = 10.5;
            MaxTemperature = 120.0;
        }

        public IActionResult OnPost(string BoilerId, DateTime DateOfPurchase, double MaxPressure, double MaxTemperature)
        {
            // Save boiler info logic (e.g., store in a database or file)
            return Page();
        }

        public IActionResult OnPostChangePassword()
        {
            // Logic to change password (you'd ideally save this in a secure storage)
            PasswordChanged = true;
            return Page();
        }
    }
}

