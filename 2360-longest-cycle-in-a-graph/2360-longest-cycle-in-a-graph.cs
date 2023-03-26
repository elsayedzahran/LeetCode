public class Solution {
    public int LongestCycle(int[] edges) {
         int ans = -1, curr = 1;
         int[] visited = new int[edges.Length]; 
        
         for (int i = 0; i < edges.Length; ++i) {
             
             if (visited[i] > 0)
                continue;
             int newcurr = curr;
             int u = i;
             while (u != -1 && visited[u] == 0) {
                 visited[u] = curr++; 
                 u = edges[u]; 
             }
             if (u != -1 && visited[u] >= newcurr)
                ans = Math.Max(ans, curr - visited[u]);
        }

        return ans;
    }
}