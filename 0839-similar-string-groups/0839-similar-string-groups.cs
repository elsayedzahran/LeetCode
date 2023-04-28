public class Solution {
    int[] parent;
    int[] rank;

    public int NumSimilarGroups(string[] strs) {
        int size = strs.Length;
        parent = new int[size];
        rank = new int[size];
        int count = 0;

        for (int i = 0; i < size; i++) 
        {
            parent[i] = i;
            rank[i] = 1;
        }

        for (int i = 0; i < size; i++) 
            for (int j = i + 1; j < size; j++) 
                if (AreSimilar(strs[i], strs[j])) Union(i, j);

        for (int i = 0; i < strs.Length; i++) 
            if (parent[i] == i) count++;

        return count;
    }
    
    int Find(int x) 
    {
        if (parent[x] != x) parent[x] = Find(parent[x]);
        return parent[x];
    }

    void Union(int x, int y) 
    {
        int rootX = Find(x);
        int rootY = Find(y);

        if (rootX == rootY) return;

        if (rank[rootX] < rank[rootY]) parent[rootX] = rootY;
        else if (rank[rootX] > rank[rootY]) parent[rootY] = rootX;
        else 
        {
            parent[rootY] = rootX;
            rank[rootX]++;
        }
    }

    bool AreSimilar(string s1, string s2) {
        if (s1 == s2) return true;

        int diffCount = 0;
        for (int i = 0; i < s1.Length; i++) 
        {
            if (s1[i] != s2[i]) 
            {
                diffCount++;
                if (diffCount > 2) return false;
            }
        }

        return diffCount == 2;
    }
}