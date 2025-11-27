using System;

public class SingleLevel
{
    public class Vehicle
    {

    public string VehicleType;
    public void Engine()
    {
        Console.WriteLine("Engine started!");
    }
    }
    public class Car:Vehicle{
        public Car()
        {
            Console.WriteLine($"Car is started ");
        }
    }
}