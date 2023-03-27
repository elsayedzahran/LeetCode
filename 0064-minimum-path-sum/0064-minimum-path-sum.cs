public class Solution {
    public int MinPathSum(int[][] grid) {
        var dp = new int[grid.Length, grid[0].Length];
        return GetMin(grid, dp, grid.Length-1, grid[0].Length-1);
    }
    int GetMin(int[][] grid,int[,] dp,int x,int y){
        if(x < 0 || y < 0) 
            return int.MaxValue;
        
        if(x == 0 && y == 0) 
            return grid[x][y];
        
        if(dp[x,y] != 0) 
            return dp[x,y];
        
        dp[x,y] = Math.Min(GetMin(grid, dp, x-1, y),GetMin(grid, dp, x, y-1)) + grid[x][y];
        return dp[x,y];
    }
}