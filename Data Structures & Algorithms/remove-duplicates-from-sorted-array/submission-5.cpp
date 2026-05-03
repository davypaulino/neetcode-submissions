// Big O (n)
class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        int s = 1;
        for (int i = 1; i < nums.size(); i++) {
            if (nums[i] != nums[i - 1]) {
                nums[s++] = nums[i];
            }
        }
        nums.resize(s);
        return nums.size();
    }
};