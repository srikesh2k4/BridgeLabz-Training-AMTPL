using System.Collections;
namespace BridgeLabzApp.Collections.NonGeneric;

public class LearnHashtable
{
    public LearnHashtable()
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add(21,"Srikesh");
        hashtable.Add("Ashok",31);
        foreach (DictionaryEntry dictionaryEntry in hashtable)
        {
            Console.WriteLine(dictionaryEntry.Key + " => " + dictionaryEntry.Value);
        }
    }
}