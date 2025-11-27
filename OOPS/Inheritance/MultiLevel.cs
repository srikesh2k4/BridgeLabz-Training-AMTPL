using System;
namespace BridgeLabzApp.OOPS.Inheritance;

public class MultiLevel
{
    public class A
    {
        public string IsA;
        public A()
        {
            Console.WriteLine("This is A");
        }
    }

    public class B:A
    {
        public string IsB;

        public B()
        {
           Console.WriteLine("This is b"); 
        }
    }
    public class C:B
    {
        public string IsC;

        public C()
        {
            Console.WriteLine("This is C"); 
        }
    }
}