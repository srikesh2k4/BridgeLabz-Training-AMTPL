using System;
using System.IO;

namespace IOStreamsDemo
{
    class Program
    {
        static void Main()
        {
            string path = "sample.txt";

            using (FileStream fs = new FileStream(path, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine("Hello Streams");
            }

            using (FileStream fs = new FileStream(path, FileMode.Open))
            using (StreamReader reader = new StreamReader(fs))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}