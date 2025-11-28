namespace BridgeLabzApp.Collections.Generic;

public class LearnSortedListGeneric
{
    public LearnSortedListGeneric()
    {
        SortedList<int, int> sortedList = new SortedList<int, int>();
        sortedList.Add(1,2);
        sortedList.Add(2,1);
        sortedList.Add(3,2);
        sortedList.Add(4,1);
        sortedList.Remove(2);
        foreach (KeyValuePair<int,int> i in sortedList)
        {
            Console.WriteLine(i.Key + "=>" + i.Value);
        }
    }
}