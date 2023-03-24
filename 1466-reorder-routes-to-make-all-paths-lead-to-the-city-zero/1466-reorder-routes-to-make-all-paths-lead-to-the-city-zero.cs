public class Solution {
    public int MinReorder(int n, int[][] connections) {
        List<List<int>> graph = new List<List<int>>(n);
        
        for(int i = 0; i < n; ++i) 
            graph.Add(new List<int>());
        
        foreach (var c in connections) {
            graph[c[0]].Add(c[1]);
            graph[c[1]].Add(-c[0]);
        }
        return dfs(graph, new bool[n], 0);
    }
    int dfs(List<List<int>> graph, bool[] visited, int from) {
        int change = 0;
        visited[from] = true;
        
        foreach (var to in graph[from])
            if (!visited[Math.Abs(to)])
                change += dfs(graph, visited, Math.Abs(to)) + (to > 0 ? 1 : 0);
        return change;   
    }
}