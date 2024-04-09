using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WeatherMontitoringSystem_Library
{
    /// <summary>
    /// Represents a display showing current weather conditions including temperature, humidity, and wind speed.
    /// </summary>
    public class CurrentConditions_Display : IDisplay
    {
        private Weather_Data weather_Data;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentConditions_Display"/> class.
        /// </summary>
        /// <param name="weather_Data">The weather data subject.</param>
        public CurrentConditions_Display(Weather_Data weather_Data)
        {
            this.weather_Data = weather_Data;
        }

        /// <summary>
        /// Displays current weather conditions including temperature, humidity, and wind speed.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Current Weather Conditions:");
            Console.WriteLine();
            Console.WriteLine($"Temperature is: {weather_Data.Temperature}°C");
            Console.WriteLine($"Humidity is: {weather_Data.Humidity}%");
            Console.WriteLine($"Wind Speed is: {weather_Data.WindSpeed} km/h");

            // Decorate the display with additional information(date and time)
            Console.WriteLine($"Current Date and Time: {DateTime.Now}");

            Console.WriteLine();
        }
    }
}
