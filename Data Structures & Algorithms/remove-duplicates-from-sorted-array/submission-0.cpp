class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        vector<int> newNums;
        if (nums.size() == 0)
            return 0;
        newNums.push_back(nums[0]);
        for (int i = 1; i < nums.size(); i++) {
            if (nums[i] == nums[i - 1]) {
                continue ;
            }
            newNums.push_back(nums[i]);
        }
        nums = newNums;
        return newNums.size();
    }
};