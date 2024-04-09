using System;

namespace WeatherMontitoringSystem_Library
{
    /// <summary>
    /// Represents a weather station that creates display objects for weather data.
    /// </summary>
    public class Weather_Station
    {
        /// <summary>
        /// Creates a display object based on the specified display type.
        /// </summary>
        /// <param name="displayType">The type of display to create (e.g., "CurrentConditions", "Statistics", "Forecast").</param>
        /// <returns>The created display object.</returns>
        public IDisplay CreateDisplay(string displayType)
        {
            Weather_Data weather_Data = Weather_Data.Instance;

            switch (displayType)
            {
                case "CurrentConditions":
                    return new CurrentConditions_Display(weather_Data);
                case "Statistics":
                    return new Statistics_Display(weather_Data);
                case "Forecast":
                    return new Forecast_Display(weather_Data);
                default:
                    throw new ArgumentException("Invalid display type..!");
            }
        }
    }
}
