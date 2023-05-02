public class Solution {
    public int ArraySign(int[] nums) {
        if (nums.Contains(0)) 
            return 0;
        int count = nums.Count(p => p < 0);
        return count % 2  == 0 ? 1 : -1;
    }
}