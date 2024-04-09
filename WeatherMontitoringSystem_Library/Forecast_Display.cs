using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMontitoringSystem_Library
{
    /// <summary>
    /// Represents a display showing weather forecast based on temperature conditions.
    /// </summary>
    public class Forecast_Display : IDisplay
    {
        private Weather_Data weather_Data;

        /// <summary>
        /// Initializes a new instance of the <see cref="Forecast_Display"/> class.
        /// </summary>
        /// <param name="weather_Data">The weather data subject.</param>
        public Forecast_Display(Weather_Data weather_Data)
        {
            this.weather_Data = weather_Data;
            // Subscribe to weather_Data's events
        }

        /// <summary>
        /// Displays weather forecast based on temperature conditions.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Weather Forecast:");
            if (weather_Data.Temperature < 0)
            {
                Console.WriteLine("Freezing with a chances of snow or icy conditions.!");
            }
            else if (weather_Data.Temperature < 10)
            {
                Console.WriteLine("Cold with a chances of rain or snow showers.!");
            }
            else if (weather_Data.Temperature < 20)
            {
                Console.WriteLine("Cool with a chances of light rain showers.!");
            }
            else if (weather_Data.Temperature < 30)
            {
                Console.WriteLine("Warm with a chances of sunny.!");
            }
            else
            {
                Console.WriteLine("Hot with clear skies.!");
            }
            Console.WriteLine();
        }
    }
}
