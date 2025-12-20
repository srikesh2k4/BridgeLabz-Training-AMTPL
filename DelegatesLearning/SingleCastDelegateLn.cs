namespace BridgeLabzApp.DelegatesLearning;

public class SingleCastDelegateLn
{
    public class Learn
    {
        public static void Book(string message)
        {
            Console.WriteLine("Reading a book"+message);
        }
    }
    public delegate void Student(string message);

    public SingleCastDelegateLn()
    {
        Student student = Learn.Book;
        student("this is single");
    }

}