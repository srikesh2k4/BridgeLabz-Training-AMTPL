using System;
using BridgeLabzApp.OOPS.Inheritance;

public class Hybrid
{
    interface IA
    {
        public void A();
    }

    interface IB
    {
        public void B();
    }

    class C : IA, IB
    {
        public void A()
        {
            Console.WriteLine("This is A");
        }

        public void B()
        {
            Console.WriteLine(" This is B");
        }
    }

    class D : C
    {
        public D()
        {
            Console.WriteLine("This is good");
        }
        
    }
    
}