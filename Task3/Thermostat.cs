namespace Task3;
public class Thermostat : IDevice
{
    public double Temperature { get;  set; }

    public void TurnOn()
    {
        Console.WriteLine("Thermostat turned on");
    }

    public void TurnOff()
    {
        Console.WriteLine("Thermostat turned off");
    }

}
