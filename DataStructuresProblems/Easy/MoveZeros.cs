namespace BridgeLabzApp.DataStructuresProblems.Easy;

public class MoveZeros
{
    public MoveZeros()
    {
        int[] nums = new int[] { 0, 1, 0, 3, 12 };

        int i = 0;

        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[j] != 0)
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                i++;
            }
        }
        

        foreach (var num in nums)
        {
            Console.Write(num+" ");
            
        }
    }
}