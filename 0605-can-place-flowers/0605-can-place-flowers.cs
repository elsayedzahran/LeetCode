public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if (flowerbed.Length == 1 && flowerbed[0] == 0 && n <= 1)
            return true;
        int cnt = 0, res = 0 , prev = -1;
        foreach (var item in flowerbed){
            if (item == 1){
                if (prev == -1){
                    res += (cnt/2);
                    prev = item;
                }
                else{
                    cnt -= 2;
                    int div = cnt/2;
                    cnt -= div;
                    if(cnt > 0) 
                        res += cnt;
                }
                cnt = 0;
            }
            else
                cnt++;
        }
        if (cnt > 0 && prev != -1) 
            res += cnt/2;
        else if (cnt > 0 && prev == -1){
            int div = cnt/2;
            cnt -= div;
            if(cnt > 0) 
               res += cnt;
        } 
        return res >= n;
    }
}