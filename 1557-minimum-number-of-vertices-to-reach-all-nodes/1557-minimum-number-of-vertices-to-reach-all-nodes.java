class Solution {
    public List<Integer> findSmallestSetOfVertices(int n, List<List<Integer>> edges) {
        var indegree = new int[n];
        for (var edge : edges) {
            indegree[edge.get(1)]++;
        }
        var ans = new ArrayList<Integer>();
        for (int i = 0; i < n; i++) {
            if (indegree[i] == 0) {
                ans.add(i);
            }
        }

        return ans;
    }
}