public class Solution {
    public int LargestPathValue(string colors, int[][] edges) {
        var rs = -1;
        var dic = CreateLargestPathValueDictionary(colors.Length, edges);
        var startNodes = GetStartNodes(colors.Length, edges);
        var count = 0;
        for (int i = 0; i < startNodes.Count; i++)
        {
            var count0 = CountNodes(startNodes[i], dic);
            if (count0 == -1) return -1;
            var rs0 = GetResult(startNodes[i], new Dictionary<int, int[]>(), colors, dic);
            var max = rs0.Max();
            if (rs < max) rs = max;
            count += count0;
        }
        if (count < colors.Length) return -1;
        return rs;
    }
    int[] GetResult(
        int index, Dictionary<int, int[]> dpDic, string colors, 
        Dictionary<int, List<int>> dic)
    {
        if (dpDic.ContainsKey(index)) return dpDic[index];
        var rs = new int[26];
        for (int i = 0; i < dic[index].Count; i++)
        {
            var rs0 = GetResult(dic[index][i], dpDic, colors, dic);
            for (int j = 0; j < rs0.Length; j++)
            {
                if (rs[j] < rs0[j]) rs[j] = rs0[j];
            }
        }
        rs[colors[index] - 'a'] += 1;
        if (!dpDic.ContainsKey(index)) dpDic.Add(index, rs);
        return rs;
    }
    int CountNodes(int index, Dictionary<int, List<int>> dic)
    {
        var count = 0;
        var visited = new HashSet<int> { index };
        var level = new HashSet<int> { index };
        while (level.Count > 0)
        {
            var level2 = new HashSet<int>();
            foreach (var item in level)
            {
                for (int i = 0; i < dic[item].Count; i++)
                {
                    level2.Add(dic[item][i]);
                    visited.Add(dic[item][i]);
                }
            }
            count++;
            if (count > dic.Count) return -1;
            level = level2;
        }
        return visited.Count;
    }
    List<int> GetStartNodes(int length, int[][] edges)
    {
        var list = new List<int>();
        for (int i = 0; i < length; i++)
        {
            list.Add(i);
        }
        var endNodes = new HashSet<int>();
        foreach (var edge in edges)
        {
            endNodes.Add(edge[1]);
        }
        list = list.Except(endNodes).ToList();
        return list;
    }
    Dictionary<int, List<int>> CreateLargestPathValueDictionary(int length, int[][] edges)
    {
        var dic = new Dictionary<int, List<int>>();
        for (int i = 0; i < length; i++)
        {
            dic.Add(i, new List<int>());
        }
        for (int i = 0; i < edges.Length; i++)
        {
            dic[edges[i][0]].Add(edges[i][1]);
        }
        return dic;
    }
}