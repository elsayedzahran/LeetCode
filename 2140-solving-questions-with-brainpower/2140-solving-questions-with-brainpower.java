class Solution {
    public long mostPoints(int[][] questions) {
        int n = questions.length;
        long[] dp = new long[n];
        Arrays.fill(dp, -1);
        return solve(0, n, dp, questions);
    }
    public long solve(int idx, int n, long[] dp, int[][] questions){
        if (idx >= n) 
            return 0;
        if (dp[idx] != -1)
            return dp[idx];
        long leave = solve(idx+1, n, dp, questions);
        long take = solve(idx + questions[idx][1] +1, n, dp, questions) + questions[idx][0];
        dp[idx] = Math.max(take, leave);
        return dp[idx];
    }
}