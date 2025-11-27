
namespace BridgeLabzApp.OOPS.Polymorphism;

public class Overriding
{

    public class Student
    {
        public virtual void Name()
        {
            Console.WriteLine("I am Srikesh");
        }
    }

    public class SchoolStudent:Student
    {
        public override void Name()
        {
            Console.WriteLine("I am Amt");
        }
    }

    public Overriding()
    {
        SchoolStudent schoolStudent = new SchoolStudent();
        schoolStudent.Name();
        Student student = new Student();
        student.Name();

        Student studentOver = new SchoolStudent();
        studentOver.Name();
    }
    
}