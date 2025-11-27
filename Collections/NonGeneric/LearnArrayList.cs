using System.Collections;
namespace BridgeLabzApp.Collections.NonGeneric;

public class LearnArrayList
{
    public LearnArrayList()
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add("Srikesh");
        arrayList.Add(21);
        arrayList.Add(19);
        arrayList.Remove(19);
        int count = arrayList.Count;
        Console.WriteLine(count+"<=Count");
        foreach (var value in arrayList)
        {
            Console.WriteLine(value+"=>");
        }
    }

    public void AddValue()
    {
        Console.WriteLine("This is add");
    }
}