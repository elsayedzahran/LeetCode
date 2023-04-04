public class Solution {
    public int PartitionString(string s) {
        var map = new HashSet<char>();
        var count = 1;

        for (var i = 0; i < s.Length; i++)
        {
            if (map.Contains(s[i]))
            {
                count++;
                map.Clear();
            }

            map.Add(s[i]);
        }

        return count;
    }
}