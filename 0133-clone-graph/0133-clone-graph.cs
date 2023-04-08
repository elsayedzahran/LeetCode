/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null){
            return null;
        }
        
        Dictionary<int, Node> visited = new();
        return DFS(node, visited);
    }
    public Node DFS(Node node, Dictionary<int, Node> visited){
        if(visited.ContainsKey(node.val)){
            return visited[node.val];
        }

        Node newNode = new Node(node.val, new List<Node>());
        visited.Add(node.val, newNode);

        foreach(var neighbor in node.neighbors){
            newNode.neighbors.Add(DFS(neighbor, visited));
        }

        return newNode;
    }
}