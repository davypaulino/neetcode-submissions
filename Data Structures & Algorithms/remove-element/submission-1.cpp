// Big O (n)
class Solution {
public:
    int removeElement(vector<int>& nums, int val) {
        vector<int> newNums;
        for (int i = 0; i < nums.size(); i++) {
            if (nums[i] == val) {
                continue;
            }
            newNums.push_back(nums[i]);
        }
        nums = newNums;
        return nums.size();
    }
};