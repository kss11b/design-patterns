using System; 
using System.Collections; 
using System.Collections.Generic;
public class WeatherData : ISubject
{
    private List<IObserver> observers; 
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData() {
        observers = new List<IObserver>();
    }

    public void registerObserver (IObserver o)
    {
        observers.Add(o);
    }

    public void removeObserver (IObserver o)
    {
        int i = observers.IndexOf(o);
        if (i >= 0){
            observers.RemoveAt(i);
        }
    }

    public void notifyObservers()
    {
        foreach (var observer in observers){
            observer.update(temperature, humidity, pressure);
        }
    }

    public void measurementsChanged()
    {
        notifyObservers();
    }

    public void setMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        measurementsChanged();
    }
}