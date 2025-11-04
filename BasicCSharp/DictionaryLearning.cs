using System;

namespace BridgeLabzApp.BasicCSharp
{
	public class DictionaryLearning
	{
		public DictionaryLearning()
		{
			Dictionary<int, string> dictName = new Dictionary<int, string>()
			{
				{1,"Srikesh" },
				{10,"Ashok" }
			};
			dictName.Add(3, "Srikesh");
			for (int i =0;i < dictName.Count; i++)
			{
				KeyValuePair<int, string> pair = dictName.ElementAt(i);
				Console.WriteLine($"{pair.Key}=>{pair.Value}");
			}
			foreach (KeyValuePair<int,string> item in dictName)
			{
				Console.WriteLine($"{item.Key} ==> {item.Value}");
			}

			Console.WriteLine();

			Dictionary<string, string> teacher = new Dictionary<string, string>()
			{
				{"Math","Srikesh" },
				{"Science","Ganesh" }
			};
			Console.WriteLine(teacher["Math"]);
			if (teacher.TryGetValue("Math",out string? teacherName))
			{
				teacher["Math"] = "Ashok";
				Console.WriteLine(teacherName);
			}
			Console.WriteLine(teacher["Math"]);
			if (teacher.ContainsKey("Math"))
			{
				teacher.Remove("Math");
			}
			if (teacher.TryGetValue("Math",out string? name))
			{
				Console.WriteLine(name);
			}
			else
			{
				Console.WriteLine("Not present");
			}
		}
	}
}

