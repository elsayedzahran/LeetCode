public class Solution {
    public int ArraySign(int[] nums) {
        int neg = 0;
        foreach (int num in nums){
            if (num < 0)
                neg++;
            if (num == 0)
                return 0;
        }
        return neg % 2 == 0 ? 1 : -1;
    }
}