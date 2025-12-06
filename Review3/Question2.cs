/*Q2: Implement a Custom Singly Linked List for Employee Objects
   Create classes:
   Employee
   Node
   CustomLinkedList
   
   Tasks:
   Implement methods:
   AddFirst(Employee emp)
   AddLast(Employee emp)
   Remove(int employeeId)
   Search(string name)
   Display()
   
   Do not use List<T> or built-in LinkedList<T>.
   Insert 5 employees and perform all operations.*/

//head => [value,next] => [value,next] => null
namespace BridgeLabzApp.Review3;

public class Question2
{
    public class Employee
    {
        public int employeeId { get; set; }
        public string name { get; set; }
        
        public Employee(int id, string Name)
        {
            employeeId = id;
            name = Name;
        }
    }
    public class Node
    {
        public Employee value { get; set; }
        public Node next { get; set; }

        public Node(Employee Value)
        {
            value = Value;
        }
    }

    public class CustomLinkedList
    {
        public Node head;
        
        public void AddFirst(Employee emp)
        {
            Node node = new Node(emp);
            node.next = head;
            head = node;
        }

        public void AddLast(Employee emp)
        {
            Node node = new Node(emp);

            if (head == null)
            {
                head = node;
                
                return;
            }

            Node temp = head;
            while (temp.next != null)
                temp = temp.next;

            temp.next = node;
        }

        public void Remove(int employeeId)
        {
            if (head == null) 
                return;

            if (head.value.employeeId == employeeId)
            {
                head = head.next;
                return;
            }

            Node prev = null;
            Node temp = head;

            while (temp != null && temp.value.employeeId != employeeId)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
            {
                Console.WriteLine("Employee not found.");
                return;
            }

            prev.next = temp.next;
        }

        public Employee Search(string name)
        {
            Node temp = head;

            while (temp != null)
            {
                if (temp.value.name == name)
                    return temp.value;

                temp = temp.next;
            }

            return null;
        }
        public void Display()
        {
            Node temp = head;

            Console.WriteLine("\nEmployee List:");

            while (temp != null)
            {
                Console.WriteLine($"{temp.value.employeeId} - {temp.value.name}");
                temp = temp.next;
            }
        }
    }
    
}