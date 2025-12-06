/*Custom Doubly Linked List
1) Student Doubly Linked List
Create:
Student
DNode
DoublyLinkedList

Implement:
Add at front
Add at end
Delete by roll number
Reverse traversal
Forward traversal

Custom Singly Linked List

*/
namespace BridgeLabzApp.Review3;

public class Question1
{
    public class Student
    {
        public int Roll { get; set; }
        public string Name { get; set; }
        public Student(int roll, string name)
        {
            Roll = roll;
            Name = name;
        }
    }
    public class DNode
    {
        public Student Data { get; set; }
        public DNode Prev { get; set; }
        public DNode Next { get; set; }

        public DNode(Student value)
        {
            Data = value;
        }
    }

    public class DoublyLinkedList
    {
        public DNode head;
        public DNode tail;

        public void AddFront(Student s)
        {
            DNode node = new DNode(s);

            if (head == null)
                head = tail = node;
            else
            {
                node.Next = head;
                head.Prev = node;
                head = node;
            }
        }

        public void AddEnd(Student s)
        {
            DNode node = new DNode(s);

            if (head == null) 
            {
                head = tail = node;
                return;
            }

            tail.Next = node;  
            node.Prev = tail;     
            tail = node;          
        }

        public void Delete(int roll)
        {
            DNode temp = head;

            while (temp != null)
            {
                if (temp.Data.Roll == roll)
                {
                    if (temp == head)
                    {
                        head = head.Next;
                        if (head != null) 
                            head.Prev = null;
                    }
                    else if (temp == tail)
                    {
                        tail = tail.Prev;
                        tail.Next = null;
                    }
                    else
                    {
                        temp.Prev.Next = temp.Next;
                        temp.Next.Prev = temp.Prev;
                    }

                    return;
                }

                temp = temp.Next;
            }

            Console.WriteLine("Student not found.");
        }

        public void PrintReverse()
        {
            Console.WriteLine("Reverse Traversal:");
            DNode temp = tail;

            while (temp != null)
            {
                Console.WriteLine($"{temp.Data.Roll} - {temp.Data.Name}");
                temp = temp.Prev;
            }
        }

        public void PrintForward()
        {
            Console.WriteLine("Forward Traversal:");
            DNode temp = head;

            while (temp != null)
            {
                Console.WriteLine($"{temp.Data.Roll} - {temp.Data.Name}");
                temp = temp.Next;
            }
        }
    }
}













