namespace BridgeLabzApp.Collections.Generic;

public class LearnStackGeneric
{
    public LearnStackGeneric()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(21);
        stack.Push(31);
        stack.Push(41);
        stack.Pop();
        foreach (var i in stack)
        {
            Console.WriteLine(i);
        }
    }
}