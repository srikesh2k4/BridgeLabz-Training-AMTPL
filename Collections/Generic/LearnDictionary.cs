namespace BridgeLabzApp.Collections.Generic;

public class LearnDictionary
{
    public LearnDictionary()
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        dictionary.Add(1,2);
        dictionary.Add(2,3);
        dictionary.Remove(2);
        dictionary.Add(21,2);

        foreach (KeyValuePair<int,int> keyValuePair in dictionary)
        {
            Console.WriteLine(keyValuePair.Key+" Key "+"=>"+ keyValuePair.Value+" Value");
        }
    }
}