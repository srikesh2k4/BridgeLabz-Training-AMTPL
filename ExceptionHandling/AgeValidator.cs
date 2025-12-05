namespace BridgeLabzApp.ExceptionHandling;

public class AgeValidator
{
    public void ValidateAge(int age)
    {
        if (age >= 18)
        {
            Console.WriteLine("Valid age");
        }
        else
        {
            throw new CustomException("Invalid age is this");
        }
    }
}