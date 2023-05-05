class Solution {
    public int maxVowels(String s, int k) {
        int n = s.length();
        int ans = 0 , res = 0;
        for (int i=0 ; i<k ; i++){
            if (validate(s.charAt(i)))
                ans++;
        }
        res = ans;
        int r = k;
        while (r < n){
            if (validate(s.charAt(r-k)))
                ans--;
            if (validate(s.charAt(r)))
                ans++;
            res = Math.max(res,ans);
            r++;
        }
        return res;
    }
    boolean validate(char ch){
        return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
    }
}