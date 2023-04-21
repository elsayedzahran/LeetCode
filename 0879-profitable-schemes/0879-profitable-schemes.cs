public class Solution {
    public int ProfitableSchemes(int n, int minProfit, int[] group, int[] profit) {
        const int mod = 1000000000 + 7;
        int[,] dp = new int[minProfit + 1, n + 1];
        dp[0, 0] = 1;
        for (var k = 0; k < group.Length; k++)
        {
            int g = group[k];
            int p = profit[k];
            
            for (var i = minProfit; i >= 0; i--)
            {
                for (var j = n - g; j >= 0; j--)
                {
                    dp[Math.Min(i + p, minProfit), j + g] = 
                        (dp[Math.Min(i + p, minProfit), j + g] + dp[i, j]) % mod;
                }
            }
        }
        
        var res = 0;

        for (var i = 0; i <= n; i++)
        {
            res += dp[minProfit, i];
            res %= mod;
        }
        return res;
    }
}