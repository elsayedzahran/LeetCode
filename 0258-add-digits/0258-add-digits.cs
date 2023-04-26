public class Solution {
    public int AddDigits(int num) {
        while (num > 9){
            int res = num;
            num = 0;
            while (res > 0){
                num += res%10;
                res /= 10;
            }
        }
        return num;
    }
}