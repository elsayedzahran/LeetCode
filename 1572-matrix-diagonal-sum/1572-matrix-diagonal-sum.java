class Solution {
    public int diagonalSum(int[][] mat) {
        int n = mat.length, res = 0;
        int right = n-1;
        for (int i = 0 ; i < n ; i++){
            if (n%2 == 0 || i != n/2)
                res += mat[i][i];
            res += mat[i][right--];
        }
        
        return res;
    }
}