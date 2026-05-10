public class Solution {
    public int MaxSubArray(int[] nums) {
        var max = nums[0];
        var cur = 0;

        foreach (var n in nums) {
            cur += n;
            if (cur > max) {
                max = cur;
            }

            if (cur < 0) {
                cur = 0;
                continue;
            }
        }

        return max;
    }
}
