using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;
using BoilerApp;

namespace BoilerApp.Pages
{
    public class RecommendationsModel : PageModel
    {
        public List<string> Recommendations { get; set; }

        public void OnGet()
        {
            Recommendations = new List<string>();

            
            foreach (var reading in BoilerData.Readings)
            {
                if (reading.Temperature > 100)
                {
                    Recommendations.Add($"Temperature ({reading.Temperature}°C) is above the safe limit. Consider lowering it.");
                }
                if (reading.Pressure > 8)
                {
                    Recommendations.Add($"Pressure ({reading.Pressure} Bar) is too high. Consider reducing it.");
                }
            }

            if (!Recommendations.Any())
            {
                Recommendations.Add("All readings are within the safe limits.");
            }
        }
    }
}
