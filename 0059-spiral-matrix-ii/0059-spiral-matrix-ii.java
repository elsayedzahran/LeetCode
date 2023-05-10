class Solution {
    public int[][] generateMatrix(int n) {
        
        int[][] ans = new int[n][n];
        int count = 1;
        int total = n * n;
        
        int startingRow = 0;
        int endingRow = n - 1;
        int startingCol = 0;
        int endingCol = n - 1;
        
        while (count <= total) {
            
            for (int i = startingCol; i <= endingCol; i++) {
                ans[startingRow][i] = count;
                count++;
            }
            startingRow++;
            
            for (int i = startingRow; i <= endingRow; i++) {
                ans[i][endingCol] = count;
                count++;
            }
            endingCol--;
            
            for (int i = endingCol; i >= startingCol; i--) {
                ans[endingRow][i] = count;
                count++;
            }
            endingRow--;
            
            for (int i = endingRow; i >= startingRow; i--) {
                ans[i][startingCol] = count;
                count++;
            }
            startingCol++;
        }
        
        return ans;
    }
}