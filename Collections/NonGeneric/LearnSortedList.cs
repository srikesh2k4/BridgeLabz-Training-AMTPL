using System.Collections;

namespace BridgeLabzApp.Collections.NonGeneric;

public class LearnSortedList
{
    public LearnSortedList()
    {
        SortedList sortedList = new SortedList(StringComparer.Ordinal);
        sortedList.Add("12",1);
        sortedList.Add("A",2);
        sortedList.Add("a",3);
        sortedList.Remove("12");
        foreach (DictionaryEntry dictionaryEntry in sortedList)
        {
            Console.WriteLine(dictionaryEntry.Key+" => "+dictionaryEntry.Value);
        }
    }
}