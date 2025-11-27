namespace BridgeLabzApp.OOPS.Encapsulation;

public class EncapsulationWithProperties
{
    public class StudentDetails
    {
        private string _name;
        private int _age;
        public string Work { get; set; }

        public string Name
        {
            get { return _name;}
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 200)
                {
                    this._age = value;
                }
                else
                {
                    throw new Exception("Cant be greater");
                }
                
            }
        }
    }

    public EncapsulationWithProperties()
    {
        StudentDetails studentDetails = new StudentDetails();
        studentDetails.Work = "Teacher";
        Console.WriteLine(studentDetails.Work);
    }
}