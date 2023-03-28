public class Solution {
    public int MincostTickets(int[] days, int[] costs) {
        int[] dp = new int[366];
        var travels = new List<int>();
        foreach (var day in days) {
            travels.Add(day);
        }
        for (int i = 1; i <= 365; i++) {
            if (!travels.Contains(i))
                dp[i] = dp[i-1];
            else
                dp[i] = Math.Min(dp[i-1] + costs[0],
                                 Math.Min(dp[Math.Max(0, i-7)] + costs[1],
                                          dp[Math.Max(0, i-30)] + costs[2]));
        }
        return dp[365];
    }
}