public class Solution {
    public int MinInsertions(string s) {
        var dp = new int[s.Length][];
        for (int i = 0; i < dp.Length; i++)
            dp[i] = new int[s.Length];

        return Solver(dp, s, 0, s.Length - 1);
    }
    int Solver(int[][] dp, string s, int i, int k)
    {
        var result = 0;

        if (i >= k)
            return result;

        if (dp[i][k] > 0)
            return dp[i][k];

        if (s[i] == s[k])
            result = Solver(dp, s, i + 1, k - 1);
        else
            result = Math.Min(Solver(dp, s, i+1, k), Solver(dp, s, i, k-1)) + 1;

        dp[i][k] = result;

        return result;
    }
}