namespace BoilerApp
{
    
    public static class BoilerData
    {
        
        public static List<BoilerReading> Readings { get; } = new List<BoilerReading>();

        
        public static void AddReading(double temperature, double pressure)
        {
            Readings.Add(new BoilerReading
            {
                Temperature = temperature,
                Pressure = pressure,
                Timestamp = DateTime.Now 
        }
    }

    
    public class BoilerReading
    {
        public double Temperature { get; set; }
        public double Pressure { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
