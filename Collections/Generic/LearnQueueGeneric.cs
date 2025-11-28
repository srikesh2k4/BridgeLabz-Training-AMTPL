namespace BridgeLabzApp.Collections.Generic;

public class LearnQueueGeneric
{
   public LearnQueueGeneric()
   {
      Queue<int> queue = new Queue<int>();
      queue.Enqueue(21);
      queue.Enqueue(21);
      queue.Dequeue();
      foreach (int i in queue)
      {
         Console.WriteLine(i);
      }
   }
}