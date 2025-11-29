namespace BridgeLabzApp.DataStructuresProblems.Easy;

public class RemoveDuplicatesFromSortedList
{
    public RemoveDuplicatesFromSortedList()
    {
        int[] nums = new int[9]
        {
            1,1,1,2,2,3,4,4,5
        };
        int i = 0;
        int j = i + 1;
        int n = nums.Length;
        while (j < n)
        {
            if (nums[i] != nums[j])
            {
                nums[i + 1] = nums[j];
                i++;
                j++;
            }
            else
            {
                j++;
            }
        }

        int uniqueCount = i+1;

        for (int k = 0; k < uniqueCount; k++)
        {
            Console.WriteLine(nums[k]);
        }
        
        


    }
}