// See https://aka.ms/new-console-template for more information
using System;
using BridgeLabzApp.Review3;

public class Program
{
    public static void Main()
    {
        Question1.DoublyLinkedList dl = new Question1.DoublyLinkedList();

        dl.AddFront(new Question1.Student(3, "Rahul"));
        dl.AddFront(new Question1.Student(2, "Arjun"));
        dl.AddEnd(new Question1.Student(4, "Sneha"));
        dl.AddEnd(new Question1.Student(5, "Meera"));
        dl.AddFront(new Question1.Student(1, "Kiran"));

        Console.WriteLine("Doubly Linked List Forward");
        dl.PrintForward();

        Console.WriteLine("Doubly Linked List Reverse");
        dl.PrintReverse();

        Console.WriteLine("Deleting Roll 3...");
        dl.Delete(3);

        Console.WriteLine("After Deletion (Forward)");
        dl.PrintForward();

        Console.WriteLine("After Deletion (Reverse)");
        dl.PrintReverse();
        
        Question2.CustomLinkedList empList = new Question2.CustomLinkedList();

        empList.AddLast(new Question2.Employee(101, "Ravi"));
        empList.AddLast(new Question2.Employee(102, "Karan"));
        empList.AddFirst(new Question2.Employee(100, "Asha"));
        empList.AddLast(new Question2.Employee(103, "Neha"));
        empList.AddLast(new Question2.Employee(104, "David"));

        Console.WriteLine("Employee List");
        empList.Display();

        Console.WriteLine("Searching for Neha");
        Question2.Employee emp = empList.Search("Neha");

        if (emp != null)
            Console.WriteLine($"Found: {emp.employeeId} - {emp.name}");
        else
            Console.WriteLine("Not found");

        Console.WriteLine("\nRemoving Employee ID 102");
        empList.Remove(102);

        Console.WriteLine("\nAfter Removal");
        empList.Display();
    }
}