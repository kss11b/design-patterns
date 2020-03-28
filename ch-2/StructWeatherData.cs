using System.Collections.Generic;

public struct StructWeatherData {
    public float temperature {get; set;}
    public float humidity {get; set;}
    public float pressure {get; set;}

    public StructWeatherData(float temp, float humid, float psi)
    {
        temperature = temp;
        humidity = humid;
        pressure = psi;
    }
}