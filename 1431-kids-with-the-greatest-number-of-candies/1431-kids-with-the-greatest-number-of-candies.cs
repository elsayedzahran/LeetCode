public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        bool[] res = new bool[candies.Length];
        int max = -1;
        foreach (int candy in candies)
        {
            if (candy > max) max = candy;
        }
        for (int i=0; i<candies.Length ; i++){
            if (candies[i] + extraCandies >= max) res[i] = true;
            else
                res[i] = false;
        }
        return res;
    }
}