namespace BridgeLabzApp.DataStructuresProblems.Easy;

public class RemoveDuplicatesFromArrayHashSet
{
    public RemoveDuplicatesFromArrayHashSet()
    {
        HashSet<int> hashSet = new HashSet<int>(new int[]{1,2,1,2,3,2,2,3,3,3});
        foreach (var i in hashSet)
        {
            Console.WriteLine(i);
        }
    }
}