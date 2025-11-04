using System;
namespace BridgeLabzApp.BasicCSharp
{
	public class ArrayLearning
	{
		public ArrayLearning()
		{
			//int[] number = new int[5];
			//for (int i = 0; i < number.Length; i++)
			//{
			//	number[i] = Convert.ToInt32(Console.ReadLine());
			//}

			//foreach (int num in number)
			//{
			//	Console.WriteLine(num);

			//	//sort function
			//}
            int[] numb = new int[]
			{
                    1,
                    2,
                    3,
                    5,
                    6,
                    3,
                    5
			};
			foreach (int num in numb)
			{
				Console.Write(num);
			}
			Array.Sort(numb);
			Console.WriteLine();
            foreach (int num in numb)
            {
                Console.Write(num);
            }
			Array.Reverse(numb);
			Console.WriteLine();
            foreach (int num in numb)
            {
                Console.Write(num);
            }
			Console.WriteLine();
			Console.WriteLine(Array.IndexOf(numb, 6, 2, 3));
			//Array.Clear(numb,0,numb.Length);
			//for (int i =0;i < numb.Length; i++)
			//{
			//	numb[i] = default;
			//}
			//foreach(int num in numb)
			//{
			//	Console.Write(num);
			//}

        }
	}
}
