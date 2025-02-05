public class Solution {
    public int MajorityElement(int[] nums) {
         if (nums == null || nums.Length == 0)
        {
        throw new InvalidOperationException("null");
        }else if(nums.Length == 1){
            return nums[0];
        }
        Array.Sort(nums);
        int size = nums.Length;
        int majorityThreshold = size / 2;
        int count = 0;
        int current = 0;

        current = nums[0];
        count = 1;
        
        for (int i = 1; i < size; i++) {
            if (nums[i] == current) {
                count++;
                if (count > majorityThreshold) {
                    return current;
                }
            } else {
                current = nums[i];
                count = 1;
            }
        }
        
     throw new InvalidOperationException("No majority element found.");
    }
}
