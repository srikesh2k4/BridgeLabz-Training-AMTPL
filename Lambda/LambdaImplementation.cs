using System.Collections.Generic;
namespace BridgeLabzApp.Lambda;

public class LambdaImplementation
{
    public class Student
    {
        public string name { get; set; }
        public int age { get; set; }
    }

    public List<Student> list = new List<Student>();

    public LambdaImplementation()
    {
        list.Add(new Student { name = "Srikesh", age = 21 });
        list.Add(new Student { name = "Ganesh", age = 41 });
        list.Add(new Student { name = "Amrutha" , age = 31 });
        
        list.Sort((x,y) => x.age.CompareTo(y.age));
        foreach (var student in list)
        {
            Console.WriteLine($"Name {student.name} Age {student.age}");
        }
    }
}