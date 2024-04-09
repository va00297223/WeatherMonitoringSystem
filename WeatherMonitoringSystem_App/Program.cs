using System;
using WeatherMontitoringSystem_Library;

namespace WeatherMonitoringSystem.App
{
    /// <summary>
    /// Represents the entry point of the Weather Monitoring System application.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main entry point of the application.
        /// </summary>
        /// <param name="args">Command-line arguments passed to the application.</param>
        static void Main(string[] args)
        {
            Weather_Station weather_Station = new Weather_Station();

            // Create display objects
            IDisplay current_ConditionsDisplay = weather_Station.CreateDisplay("CurrentConditions");
            IDisplay statistics_Display = weather_Station.CreateDisplay("Statistics");
            IDisplay forecast_Display = weather_Station.CreateDisplay("Forecast");

            // Update weather data multiple times to generate temperature history
            for (int i = 0; i < 10; i++)
            {
                Weather_Data.Instance.UpdateWeatherData();
            }

            // Display weather data
            current_ConditionsDisplay.Display();
            statistics_Display.Display();
            forecast_Display.Display();
        }
    }
}