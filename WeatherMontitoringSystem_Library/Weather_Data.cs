using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMontitoringSystem_Library
{
    /// <summary>
    /// Represents weather data including temperature, humidity, and wind speed.
    /// </summary>
    public class Weather_Data
    {
        private static Weather_Data? instance;
        private Random random;
        private List<int> temperature_History;

        /// <summary>
        /// Initializes a new instance of the <see cref="Weather_Data"/> class.
        /// </summary>
        private Weather_Data()
        {
            random = new Random();
            temperature_History = new List<int>();
        }

        /// <summary>
        /// Gets the singleton instance of the <see cref="Weather_Data"/> class.
        /// </summary>
        public static Weather_Data Instance
        {
            get
            {
                if (instance == null)
                    instance = new Weather_Data();
                return instance;
            }
        }

        /// <summary>
        /// Gets the current temperature in degrees Celsius.
        /// </summary>
        public int Temperature { get; private set; }
        /// <summary>
        /// Gets the current humidity percentage.
        /// </summary>
        public int Humidity { get; private set; }
        /// <summary>
        /// Gets the current wind speed in kilometers per hour.
        /// </summary>
        public int WindSpeed { get; private set; }

        /// <summary>
        /// Updates weather data with random values and notifies observers.
        /// </summary>
        public void UpdateWeatherData()
        {
            // Generate random values for temperature, humidity, and wind speed
            Temperature = random.Next(-20, 40); // Random temperature between -20°C and 40°C
            Humidity = random.Next(0, 101); // Random humidity between 0% and 100%
            WindSpeed = random.Next(0, 101); // Random wind speed between 0 km/h and 100 km/h

            // Add current temperature to history
            temperature_History.Add(Temperature);
        }

        /// <summary>
        /// Retrieves the temperature history as an array.
        /// </summary>
        /// <returns>An array containing the temperature history.</returns>
        public int[] GetTemperatureHistory()
        {
            return temperature_History.ToArray();
        }
    }
}
