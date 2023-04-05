public class Solution {
    public int MinimizeArrayValue(int[] nums) {
        long ans = 0;
        long sum = 0;
        for (var i = 0; i < nums.Length; i++) {
            sum += nums[i];
        }

        for (var i = nums.Length-1; i >= 0; i--) {
            ans = Math.Max(ans, (long)Math.Ceiling(sum * 1.0 / (i+1)));
            sum -= nums[i];    
        }

        return (int)ans;
    }
}