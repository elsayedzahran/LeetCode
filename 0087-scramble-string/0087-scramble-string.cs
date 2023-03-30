public class Solution {
    Dictionary<string, bool> map = new Dictionary<string, bool>();

    public bool IsScramble(string s1, string s2) {
        return Check(s1, s2);
    }
    bool Check(string s1, string s2)
    {
        if (s1.Length == 1)
            return s1 == s2;

        if (s1 == s2)
            return true;

        string dKey = s1 + "-" + s2;
        if (map.ContainsKey(dKey))
            return map[dKey];
        
        int n = s1.Length;
        int[] f = new int[26];
        int[] s = new int[26];
        for (int i = 0; i < n; i++)
        {
            f[s1[i] - 'a']++;
            s[s2[i] - 'a']++;
        }

        if (string.Join('-', f) != string.Join('-', s))
        {
            map[dKey] = false;
            return false;
        }

        for (int i = 1; i < n; i++)
        {
            if (((Check(s1.Substring(0,i), s2.Substring(0, i))) 
                 && (Check(s1.Substring(i), s2.Substring(i)))) 
                || ((Check(s1.Substring(0, i), s2.Substring(n - i))) &&
                    (Check(s1.Substring(i), s2.Substring(0, n-i))))){
                map[dKey] = true;
                return true;
            }
        }

        map[dKey] = false;
        return false;
    }
}