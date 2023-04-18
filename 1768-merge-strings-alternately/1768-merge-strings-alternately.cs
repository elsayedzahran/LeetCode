public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string res = "";
        int n = Math.Min(word1.Length, word2.Length);
        
        for (int i=0; i<n ; i++){
            res += word1[i];
            res += word2[i];
        }
        while (n < word1.Length){
            res += word1[n++];
        }
        while (n < word2.Length){
            res += word2[n++];
        }
        return res;
    }
}