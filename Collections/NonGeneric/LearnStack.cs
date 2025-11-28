namespace BridgeLabzApp.Collections.NonGeneric;
using System.Collections;

public class LearnStack
{
    public LearnStack()
    {
        Stack stack = new Stack();
        stack.Push(12);
        stack.Push(21);
        stack.Pop();
        stack.Peek();
        stack.Contains(12);

        foreach (var s in stack)
        {
            Console.WriteLine(s+"-");
        }
    }
}