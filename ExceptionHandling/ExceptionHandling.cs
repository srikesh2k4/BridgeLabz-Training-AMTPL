namespace BridgeLabzApp.ExceptionHandling;

public class ExceptionHandling
{
    public ExceptionHandling()
    {
        /*try
        {
            int x, y;
            Console.WriteLine("Enter first number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            y = int.Parse(Console.ReadLine());
            int z = x / y;
        }
        catch (InvalidCastException invalidCastException)
        {
            Console.WriteLine(invalidCastException.Message);
        }
        catch (CustomException customException)
        {
            Console.WriteLine(customException.Message);
        }
        finally
        {
            Console.WriteLine("Tried for divide");
        }*/
        try
        {
            AgeValidator v = new AgeValidator();
            v.ValidateAge(15);
        }
        catch (CustomException ex)
        {
            Console.WriteLine("Caught custom exception: " + ex.Message);
        }
    }
}