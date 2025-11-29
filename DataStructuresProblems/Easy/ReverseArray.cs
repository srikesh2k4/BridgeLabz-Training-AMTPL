namespace BridgeLabzApp.DataStructuresProblems.Easy;

public class ReverseArray
{
    public ReverseArray()
    {
     int[] nums = new int[5]{1,2,3,4,5};
     int i = 0;
     int j = nums.Length - 1;
     while (i < j)
     {
         (nums[i], nums[j]) = (nums[j], nums[i]);
         //nums[i] = nums[i] + nums[j];
         //nums[j] = nums[i] - nums[j];
         //nums[i] = nums[i] - nums[j];
         i++;
         j--;
     }

     for (int k = 0; k < nums.Length; k++)
     {
         Console.Write(nums[k]+" ");
     }
    }
}