
using System;

public class WeatherStations
{
    // Private member variables
    private string location;
    private int temperature;
    private string condition;
    private int humidity;
    private int windSpeed;

    // Constructor
    public WeatherStations(string location, int temperature, string condition, int humidity, int windSpeed)
    {
        this.location = location;
        this.temperature = temperature;
        this.condition = condition;
        this.humidity = humidity;
        this.windSpeed = windSpeed;
    }

    // Public method to update the weather data
    public void UpdateWeather(int newTemperature, string newCondition, int newHumidity, int newWindSpeed)
    {
        SetTemperature(newTemperature);
        SetCondition(newCondition);
        SetHumidity(newHumidity);
        SetWindSpeed(newWindSpeed);

        Console.WriteLine($"Weather updated for {location}.");
        Console.WriteLine($"Temperature: {temperature}°C, Condition: {condition}, Humidity: {humidity}%, Wind Speed: {windSpeed} km/h");

        CheckExtremeWeather();
    }

    // Public method to display the current weather report
    public void ShowWeatherReport()
    {
        Console.WriteLine($"Weather in {location}:");
        Console.WriteLine($"Temperature: {temperature}°C");
        Console.WriteLine($"Condition: {condition}");
        Console.WriteLine($"Humidity: {humidity}%");
        Console.WriteLine($"Wind Speed: {windSpeed} km/h");
    }

    // Private method to check for extreme weather warnings
    private void CheckExtremeWeather()
    {
        if (temperature > 40)
        {
            Console.WriteLine("Warning: Extreme heat! Stay hydrated.");
        }
        if (temperature < 0)
        {
            Console.WriteLine("Warning: Freezing temperature! Stay warm.");
        }
        if (windSpeed > 100)
        {
            Console.WriteLine("Warning: High wind speed! Be cautious.");
        }
    }

    // Private methods to set individual properties
    private void SetTemperature(int newTemperature)
    {
        temperature = newTemperature;
    }

    private void SetCondition(string newCondition)
    {
        condition = newCondition;
    }

    private void SetHumidity(int newHumidity)
    {
        humidity = newHumidity;
    }

    private void SetWindSpeed(int newWindSpeed)
    {
        windSpeed = newWindSpeed;
    }
}