using System;
public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float temperature;
    private float humidity;
    private ISubject weatherData;

    public CurrentConditionsDisplay (ISubject weatherData) 
    {
        this.weatherData = weatherData;
        weatherData.registerObserver(this);
    }

    public void update (float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        display();
    }

    public void display() 
    {
        Console.WriteLine("Current conditions: ");
        Console.WriteLine("{0}F and", temperature);
        Console.WriteLine("{0}% humidity", humidity);
    }
}