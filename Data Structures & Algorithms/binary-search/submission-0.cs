public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right) {
            int middle = left + (right - left) / 2;

            if (target > nums[middle]) {
                left = middle + 1;
            } else if (target < nums[middle]) {
                right = middle - 1;
            } else if (target == nums[middle]) {
                return middle;
            }
        }
        
        return -1;
    }
}