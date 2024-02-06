using Task3;
Lamp lamp = new Lamp();
lamp.TurnOn();
lamp.TurnOff();
Console.WriteLine("***************");

Thermostat thermostat = new Thermostat();
thermostat.TurnOn();
thermostat.TurnOff();

Console.WriteLine("****************");

Lock doorLock = new Lock();
doorLock.TurnOn();
doorLock.TurnOff();