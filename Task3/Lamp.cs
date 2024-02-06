namespace Task3;
public class Lamp : IDevice
{
    public bool IsOn { get;  set; }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("Lamp turned on");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("Lamp turned off");
    }

}
