using System;
namespace BridgeLabzApp.BasicCSharp
{
	public class ListLearning
	{
		public ListLearning()
		{
			List<int> listNumber = new List<int>()
			{
				  1,2,3
			};
			listNumber.Add(1);
			foreach (int lN in listNumber)
			{
				Console.WriteLine(lN);
			}
			Console.WriteLine();
            listNumber.Remove(2);
            listNumber.RemoveAt(1);
            for (int i = 0; i < listNumber.Count; i++)
			{
				Console.WriteLine(listNumber[i]);
			}
			
		}
	}
}

