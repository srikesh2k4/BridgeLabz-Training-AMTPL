namespace BridgeLabzApp.OOPS.Abstraction;

public class AbstractClass
{
    public abstract class School
    {
        public abstract void SchoolName();

        public void SchoolId()
        {
            Console.WriteLine("This is school id");
        }
    }

    public class College:School
    {
        public override void SchoolName()
        {
            Console.WriteLine("This is SRM");
        }
    }
}