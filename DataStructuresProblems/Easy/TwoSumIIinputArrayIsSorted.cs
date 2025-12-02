namespace BridgeLabzApp.DataStructuresProblems.Easy;

public class TwoSumIIinputArrayIsSorted
{
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0;
        int j = numbers.Length-1;
        while(i<j){
            int sum = numbers[i]+numbers[j];
            if(sum == target){
                return new [] {i+1,j+1};
            }
            else if (sum > target){
                j--;
            }
            else if (sum < target){
                i++;
            }
        }
        return new int[0];
    }
}