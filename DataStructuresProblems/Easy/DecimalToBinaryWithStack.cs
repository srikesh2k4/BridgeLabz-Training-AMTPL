namespace BridgeLabzApp.DataStructuresProblems.Easy;

public class DecimalToBinaryWithStack
{
    public DecimalToBinaryWithStack()
    {
        Console.WriteLine("Enter number to convert to binary");
        int num = int.Parse(Console.ReadLine());

        Stack<int> stack = new Stack<int>();

        while (num > 0)
        {
            stack.Push(num%2);
            num /= 2;
        }

        while (stack.Count > 0)
        {
            int b = stack.Pop();
            Console.Write(b+" ");
        }
    }
}