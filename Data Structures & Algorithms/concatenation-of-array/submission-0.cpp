class Solution {
public:
    vector<int> getConcatenation(vector<int>& nums) {
        vector<int> ans;
        int n = nums.size();
        ans.resize(2 * n);
        for (int i = 0; i < n; i++)
        {
            int j = i + n;
            ans[i] = nums[i];
            ans[j] = nums[i];
        }
        return (ans);
    }
};