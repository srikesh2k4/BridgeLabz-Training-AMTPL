using System;

class OddEvenCheck
{
    public static string IsOddEvenCheck(int num)
    {
        if (num % 2 == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }
    }
    public OddEvenCheck()
    {
        Console.WriteLine("Enter a number to chevck odd or even");
        int num = Convert.ToInt32(Console.ReadLine());//
        string typeOddOrEven = IsOddEvenCheck(num);
        Console.WriteLine(typeOddOrEven);
    }
}
