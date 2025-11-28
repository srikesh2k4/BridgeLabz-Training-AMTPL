using System.Collections;
namespace BridgeLabzApp.Collections.NonGeneric;

public class LearnQueue
{
    public LearnQueue()
    {
        Queue queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(41);
        queue.Dequeue();
        Console.WriteLine(queue.Peek()+" is first value");
        foreach (var q in queue)
        {
            Console.Write(q+ " => ");
        }
        
    }
    
}