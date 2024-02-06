namespace Task3;
public class Lock : IDevice
{
    public bool IsLocked { get;  set; }

    public void TurnOn()
    {
        IsLocked = true;
        Console.WriteLine("Lock locked");
    }

    public void TurnOff()
    {
        IsLocked = false;
        Console.WriteLine("Lock unlocked");
    }

}
