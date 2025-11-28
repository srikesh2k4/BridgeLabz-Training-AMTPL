namespace BridgeLabzApp.Collections.Generic;

public class LearnHashSet
{
    public LearnHashSet()
    {
        HashSet<int> hashSet = new HashSet<int>(new int[] {1,2,3,2,1});
        hashSet.Add(12);
        hashSet.Remove(12);
        foreach (int i in hashSet)
        {
            Console.WriteLine(i);
        }
    }
}