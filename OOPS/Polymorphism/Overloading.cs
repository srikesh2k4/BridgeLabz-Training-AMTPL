

namespace BridgeLabzApp.OOPS.Polymorphism;

public class Overloading
{
    public class Vehicle
    {
        // Overloading method
        public int Car(int carNumber)
        {
            return carNumber;
        }

        // Method overloading
        public double Car(double carNumber, double carEngineNumber)
        {
            return carNumber + carEngineNumber;
        }

        public class Box
        {
            public int Lenght { get; }  // spelling issue but no error
            public int Breath { get; }  // spelling issue but no error

            public Box(int l, int b)
            {
                Lenght = l;
                Breath = b;
            }

            // Operator overloading
            public static Box operator +(Box a, Box b)
            {
                return new Box(a.Lenght + b.Lenght, a.Breath + b.Breath);
            }
        }
    }

    public Overloading()
    {
        Vehicle.Box a = new Vehicle.Box(2, 4);
        Vehicle.Box b = new Vehicle.Box(2, 4);

        Vehicle.Box result = a + b;

        Console.WriteLine(result.Lenght);  // Output: 4
        Console.WriteLine(result.Breath);  // Output: 8
    }
}