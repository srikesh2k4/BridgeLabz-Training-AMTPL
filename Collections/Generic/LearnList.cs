namespace BridgeLabzApp.Collections.Generic;

public class LearnList
{
   public LearnList()
   {
      List<int> list = new List<int>(new int[]{1,2,3,4,2});
      list.Add(21);
      list.Add(31);
      list.Remove(21);
      foreach (int i in list)
      {
         Console.WriteLine(i);
      }
   }
}