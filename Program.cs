using System;
using BridgeLabzApp.OOPS.Encapsulation;
using BridgeLabzApp.OOPS.Inheritance;
using BridgeLabzApp.OOPS.Polymorphism;

namespace BridgeLabzApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Single level Inheritance
            SingleLevel.Car car = new SingleLevel.Car();
            car.VehicleType = "Four vehile";
            car.Engine();
            Console.WriteLine(car.VehicleType+" is car type ");
            //MultiLevel
            MultiLevel.C c = new MultiLevel.C();
            c.IsA = "This is A";
            c.IsB = "This is B";
            Console.WriteLine(c.IsA + " & " +c.IsB);
            //Overridding
            Overriding overriding = new Overriding();
            //overloading
            Overloading overloading = new Overloading();
            //encapsulation
            EncapsulationWithProperties encapsulationWithProperties = new EncapsulationWithProperties();
            

        }
    }
}
