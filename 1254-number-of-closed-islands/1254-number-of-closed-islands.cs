public class Solution {
    public int ClosedIsland(int[][] grid) {
        int rows = grid.Length, cols = grid[0].Length, count = 0;
        
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == 0 && dfs(grid,i, j)) {
                    count++;
                }
            }
        }
        
        return count;
    }
    bool dfs(int[][] grid,int i, int j) {
        int rows = grid.Length, cols = grid[0].Length;
        
        if (i < 0 || j < 0 || i >= rows || j >= cols)
            return false;
        if (grid[i][j] == 1)
            return true;
        
        grid[i][j] = 1;
        bool left = dfs(grid,i, j-1), right = dfs(grid,i, j+1);
        bool up = dfs(grid,i-1, j), down = dfs(grid,i+1, j);
        return left && right && up && down;
    }
}