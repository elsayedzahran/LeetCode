class Solution {
    public int maxScore(int[] nums) {
        return solve(nums, new int[nums.length / 2 + 1][1 << nums.length], 1, 0);
    }
    public int gcd(int a, int b) { return b == 0 ? a : gcd(b, a % b); }
    public int solve(int[] nums, int[][] dp, int i, int mask) {
        if (i > nums.length / 2)
            return 0;
        if (dp[i][mask] == 0)
            for (int j = 0; j < nums.length; ++j)
                for (int k = j + 1; k < nums.length; ++k) {
                    int new_mask = (1 << j) + (1 << k);
                    if ((mask & new_mask) == 0)
                        dp[i][mask] = Math.max(dp[i][mask], i * gcd(nums[j], nums[k]) 
                                               + solve(nums, dp, i + 1, mask + new_mask));
                }
        return dp[i][mask];
    }
}