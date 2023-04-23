public class Solution {
    public int NumberOfArrays(string s, int k) {
        int[] dp = new int[100001];
        for (int i = 0; i < dp.Length; i++)
            dp[i] = -1;
        return solve(s, k, dp, 0);
    }
    int solve(string s, int k, int[] dp, int idx){
        int mod = 1000000007;
        if (idx == s.Length)
            return 1;
        if (dp[idx] != -1)
            return dp[idx];
        long sum = 0;
        int ans = 0;
        for (int i = idx; i < s.Length; i++)
        {
            sum = (sum * 10 + (s[i] - '0'));
            if (sum >= 1 && sum <= k)
                ans = (ans + solve(s, k, dp, i+1)) % mod;
            else
                break;
        }

        return dp[idx] = ans;
    }
}