namespace BridgeLabzApp.DataStructuresProblems.Easy;

public class CheckPalindrome
{
    public CheckPalindrome()
    {
        string strs = "malyalam";
        int i = 0;
        int j = strs.Length-1;
        bool isPalindrome = true;
        while (i < j)
        {
            if (strs[i] != strs[j])
            {
                isPalindrome = false;
            }

            i++;
            j--;
        }

        if (isPalindrome)
        {
            Console.WriteLine("This is palindrome");
        }
        else
        {
            Console.WriteLine("This is not palindrome");
        }
        
    }
}