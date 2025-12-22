using System;
using System.Reflection;

namespace ReflectionDemo
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine("Employee Display");
        }
    }

    class Program
    {
        static void Main()
        {
            Type type = typeof(Employee);

            Console.WriteLine("Properties:");
            foreach (PropertyInfo prop in type.GetProperties())
                Console.WriteLine(prop.Name);

            Console.WriteLine("Methods:");
            foreach (MethodInfo method in type.GetMethods())
                Console.WriteLine(method.Name);
        }
    }
}