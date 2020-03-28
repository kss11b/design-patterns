using System;
using System.Collections.Generic;
public class WeatherMonitor : List<IObservable<StructWeatherData>>
{
    List<IObserver<StructWeatherData>> observers;

    public WeatherMonitor()
    {
        observers = new List<IObserver<StructWeatherData>>();
    }

    private class Unsubscriber : IDisposable
    {
      private List<IObserver<StructWeatherData>> _observers;
      private IObserver<StructWeatherData> _observer;

      public Unsubscriber(List<IObserver<StructWeatherData>> observers, IObserver<StructWeatherData> observer)
      {
         this._observers = observers;
         this._observer = observer;
      }

      public void Dispose() 
      {
         if (! (_observer == null)) _observers.Remove(_observer);
      }
    }

       public IDisposable Subscribe(IObserver<StructWeatherData> observer)
   {
      if (! observers.Contains(observer))
         observers.Add(observer);

      return new Unsubscriber(observers, observer);
   }

      public void GetTemperature()
   {
      var a =  new StructWeatherData(71, 65, 22);
    var b =  new StructWeatherData(79, 55, 31);
      // Create an array of sample data to mimic a temperature device.
      List<StructWeatherData>[] weathers = { a, b };
      // Store the previous temperature, so notification is only sent after at least .1 change.
      Nullable<Decimal> previous = null;
      bool start = true;

      foreach (var weather in weathers) {
         System.Threading.Thread.Sleep(2500);
            if (start || (Math.Abs(weather.temperature - previous.temperature) >= 0.1m )) {
               StructWeatherData tempData = new StructWeatherData(weather.temp, weather.humid, WeatherData.psi);
               foreach (var observer in observers)
                  observer.OnNext(tempData);
               previous = weather;
               if (start) start = false;
            }
         else {
            foreach (var observer in observers.ToArray())
               if (observer != null) observer.OnCompleted();

            observers.Clear();
            break;
         }
      }
   }

}