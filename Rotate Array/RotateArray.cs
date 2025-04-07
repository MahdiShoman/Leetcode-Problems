public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k %= n; 

        if (n == 0 || k == 0) return;

        int[] temp = new int[n];

        //move last elements to be in the beginning of temp array

        for (int i = 0; i < k; i++) {

            temp[i] = nums[n - k + i];
        }
        //move the first elements to the continue  part of temp array
        for (int i = 0; i < n - k; i++) {

            temp[k + i] = nums[i] ;
        }

        Array.Copy(temp, nums, n);
    }
}