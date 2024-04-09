using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMontitoringSystem_Library
{
    /// <summary>
    /// Represents a display interface for displaying weather information.
    /// </summary>
    public interface IDisplay
    {
        /// <summary>
        /// Displays weather information.
        /// </summary>
        void Display();
    }
}
