using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMontitoringSystem_Library
{
    /// <summary>
    /// Represents a display showing weather statistics including average, max, and min temperatures.
    /// </summary>
    public class Statistics_Display : IDisplay
    {
        private Weather_Data weather_Data;

        /// <summary>
        /// Initializes a new instance of the <see cref="Statistics_Display"/> class.
        /// </summary>
        /// <param name="weather_Data">The weather data subject.</param>
        public Statistics_Display(Weather_Data weather_Data)
        {
            this.weather_Data = weather_Data;
            // Subscribe to weather_Data's events
        }

        /// <summary>
        /// Displays weather statistics including average, max, and min temperatures.
        /// </summary>
        public void Display()
        {
            int[] temperatures = weather_Data.GetTemperatureHistory();

            if (temperatures.Length == 0)
            {
                Console.WriteLine("Statistics Weather data are not available.!");
                return;
            }

            // Calculate statistics
            int total_Temperature = 0;
            int max_Temperature = int.MinValue;
            int min_Temperature = int.MaxValue;

            foreach (int temperature in temperatures)
            {
                total_Temperature += temperature;
                max_Temperature = Math.Max(max_Temperature, temperature);
                min_Temperature = Math.Min(min_Temperature, temperature);
            }

            double average_Temperature = (double)total_Temperature / temperatures.Length;

            // Display statistics
            Console.WriteLine("Weather Statistics:");
            Console.WriteLine($"Average Temperature is: {average_Temperature:F1}°C");
            Console.WriteLine($"Max Temperature is: {max_Temperature}°C");
            Console.WriteLine($"Min Temperature is: {min_Temperature}°C");
            Console.WriteLine();

        }
    }
}
