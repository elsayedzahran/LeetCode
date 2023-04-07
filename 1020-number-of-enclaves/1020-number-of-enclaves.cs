public class Solution {
    public int NumEnclaves(int[][] grid) {
        int row = grid.Length;
        int column = grid[0].Length;
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < column; j++) {
                if ((i == 0 || j == 0 || i == row-1 || j == column-1) && grid[i][j] == 1) {
                    dfs(grid,i, j);
                }
            }
        }

        int count = 0;
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < column; j++) {
                count += grid[i][j];
            }
        }
        return count;
    }
    void dfs(int[][] grid,int i ,int j){
        int row = grid.Length;
        int column = grid[0].Length;
        if (i < 0 || j < 0 || i >= row || j >= column || grid[i][j] == 0) {
            return;
        }
        grid[i][j] = 0;
        
        dfs(grid,i+1, j);
        dfs(grid,i-1, j);
        dfs(grid,i, j+1);
        dfs(grid,i, j-1);
    }
}