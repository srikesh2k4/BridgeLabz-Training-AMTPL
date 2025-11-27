namespace BridgeLabzApp.OOPS.Abstraction;

public class AbstractionWithInterface
{
    interface IFruit
    {
        void Fruit();
    }

    class Mango : IFruit
    {
        public void Fruit()
        {
            Console.WriteLine("This is Mango");
        }
    }
    
}