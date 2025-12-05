namespace BridgeLabzApp.Collections.Generic;

public class LearnLinkedList
{
    public LearnLinkedList()
    {
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.AddFirst(12);
        linkedList.AddLast(21);
        linkedList.AddLast(31);
        linkedList.AddLast(41);
        linkedList.AddLast(51);
        linkedList.AddLast(61);
        LinkedListNode<int> node51 = linkedList.Find(51);
        linkedList.AddAfter(node51, 21);
        
        foreach (int i in linkedList)
        {
            Console.Write(i+"=>");
        }

        Console.Write("Null");
    }
}