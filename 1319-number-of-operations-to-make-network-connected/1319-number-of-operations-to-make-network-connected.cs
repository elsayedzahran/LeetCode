public class Solution {
    public int MakeConnected(int n, int[][] connections) {
        
        if(connections.Length < n-1)
            return -1;
     
        var connectionsAsMap = BuildMapFromArray(connections);
        
        var visited = new bool[n];
        int count = -1;
        
        for(int visitedIndex = 0; visitedIndex < n; visitedIndex++){
            if(!visited[visitedIndex]){
                DFS(visitedIndex, connectionsAsMap, visited);
                count++;
            }
        }
        
        return count;
    }
    
    private void DFS(int source, Dictionary<int, List<int>> connectionsAsMap, bool[] visited){
        
        visited[source] = true;
        List<int> connectionAdjacents;
        if (connectionsAsMap.ContainsKey(source) == true)
            connectionAdjacents  = connectionsAsMap[source];
        else
            connectionAdjacents = new List<int>(); 
        
        foreach(int connectionAdjacent in connectionAdjacents){
            if(!visited[connectionAdjacent]){
                DFS(connectionAdjacent, connectionsAsMap, visited);
            }
        }
    }
    
    private Dictionary<int, List<int>> BuildMapFromArray(int[][] connections){
        
        Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();
        
        foreach(int[] connection in connections){
            
            if(!result.ContainsKey(connection[0])){
                result.Add(connection[0], new List<int>());
            }
            
            if(!result.ContainsKey(connection[1])){
                result.Add(connection[1], new List<int>());
            }
            
            result[connection[0]].Add(connection[1]);
            result[connection[1]].Add(connection[0]);
        }
        
        return result;
    }
}