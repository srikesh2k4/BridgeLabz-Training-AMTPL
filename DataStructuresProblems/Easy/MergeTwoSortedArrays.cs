namespace BridgeLabzApp.DataStructuresProblems.Easy;

public class MergeTwoSortedArrays
{
    public MergeTwoSortedArrays()
    {
        int[] nums1 = new int[]{1,2,3,4,15};
        int[] nums2 = new int[]{2,3,5,6};
        int n = nums1.Length;
        int m = nums2.Length;
        int[] nums = new int[m + n];
        int i = 0;
        int j = 0;
        int k = 0;

        while (i < n && j < m)
        {
            if (nums1[i] > nums2[j])
            {
                nums[k] = nums2[j];
                j++;
                k++;
            }
            else
            {
                nums[k] = nums1[i];
                i++;
                k++;
            }
        }

        while (i < n)
        {
            nums[k] = nums1[i];
            i++;
            k++;
        }

        while (j < m)
        {
            nums[k] = nums2[j];
            j++;
            k++;
        }



        for (int l = 0; l < nums.Length; l++)
        {
            Console.Write(nums[l]+ " ");
        }



    }
}