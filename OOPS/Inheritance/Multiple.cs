namespace DefaultNamespace;

public class Multiple
{
    interface IA
    {
        void A();
    }

    interface IB
    {
        void B();
    }

    public class C : IA, IB
    {
       public void A()
        {
            Console.WriteLine("This is A");
        }
        public void B()
        {
            Console.WriteLine("This is B");
        }
    }
    
}