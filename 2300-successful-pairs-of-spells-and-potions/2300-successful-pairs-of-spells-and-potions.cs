public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);
        var res = new int[spells.Length];
        
        for (int i = 0 ; i < spells.Length ; i++){
            
            var div = (double)success / spells[i];
            long num = (long)Math.Ceiling(div);
            
            int ret = binarySearch(num, potions.Length, potions);
            if (ret == -1)
                res[i] = 0;
            else
                res[i] = potions.Length - ret;
        }
        
        return res;
    }
    int binarySearch(long num, int size, int[] potions){
        int l = 0, r = size-1, res = -1;
        while (l <= r){
            int mid = (l+r)/2;
            if (potions[mid] >= num)
            {
                res = mid;
                r = mid - 1;
            }
            else
                l = mid + 1;
        }
        return res;
    }
}