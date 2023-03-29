public class Solution {
    public int MaxSatisfaction(int[] satisfaction) {
        Array.Sort(satisfaction);
        int n = satisfaction.Length;
        int prefix = 0, res = 0;
        for (int i = n - 1; i >= 0; i--) 
        {
            prefix += satisfaction[i];
            if (prefix < 0)
                break;
            res += prefix;
        }
        return res;
    }
}