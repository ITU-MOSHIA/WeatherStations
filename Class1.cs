using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class Program
    {
        public static void Main()
        {
            // Create a WeatherStation instance for Limpopo with initial data
            WeatherStations limpopoWeather = new WeatherStations("Limpopo", 28, "Sunny", 50, 15);

            // Display the initial weather report
            limpopoWeather.ShowWeatherReport();

            // Update the weather and show the updated report
            limpopoWeather.UpdateWeather(42, "Hot and Dry", 20, 10);

            // Show the weather report again
            limpopoWeather.ShowWeatherReport();
        }
    }
}
