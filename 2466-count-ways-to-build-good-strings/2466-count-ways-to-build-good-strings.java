class Solution {
    int mod = 1000000007;
    public int countGoodStrings(int low, int high, int zero, int one) {
        int dp[]=new int[high+1];
        Arrays.fill(dp,-1);
        int ans=0;
        for(int i = low ; i <= high ; i++){
            ans=((ans%mod) + (solve(i,dp,zero,one)%mod))%mod;
        }
        return ans;
    }
    public int solve(int idx,int[] dp,int zero,int one){
        if(idx == 0)
            return 1;
        if(idx < 0)
            return 0;
        if(dp[idx] != -1)
            return dp[idx];
        int mem_zero = solve(idx-zero, dp, zero, one);
        int mem_one = solve(idx-one, dp, zero, one);
        dp[idx]=(mem_zero + mem_one) % mod;
        return dp[idx];
    }
}