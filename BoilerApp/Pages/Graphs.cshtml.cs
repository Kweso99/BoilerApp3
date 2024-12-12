using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using BoilerApp;

namespace BoilerApp.Pages
{
    public class GraphsModel : PageModel
    {
        public string TemperatureData { get; set; }
        public string PressureData { get; set; }
        public string Timestamps { get; set; }

        public void OnGet()
        {
            // Get the data from BoilerData
            var readings = BoilerData.Readings.ToList();

            // Prepare the data for Chart.js
            TemperatureData = "[" + string.Join(", ", readings.Select(r => r.Temperature)) + "]";
            PressureData = "[" + string.Join(", ", readings.Select(r => r.Pressure)) + "]";
            Timestamps = "[" + string.Join(", ", readings.Select(r => $"\"{r.Timestamp:yyyy-MM-dd HH:mm}\"")) + "]";
        }
    }
}
