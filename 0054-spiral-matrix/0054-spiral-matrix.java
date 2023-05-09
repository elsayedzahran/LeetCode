class Solution {
    public List<Integer> spiralOrder(int[][] matrix) {
        int n = matrix.length - 1, m = matrix[0].length;
        int x = 0, y = 0;
        var list = new ArrayList<Integer>();

        while (true) {
            
          if (m == 0) break;
            
          for (int i = 0 ; i < m ; i++, y++) 
              list.add(matrix[x][y]);
          x++; y--; m--;

            
          if (n == 0) break;
            
          for (int i = 0 ; i < n ; i++, x++) 
              list.add(matrix[x][y]);
          y--; x--; n--;

          if (m == 0) break;
            
          for (int i = 0 ; i < m ; i++, y--) 
              list.add(matrix[x][y]);
          x--; y++; m--;

          if (n == 0) break;
            
          for(int i = 0 ; i < n ; i++, x--) 
              list.add(matrix[x][y]);
          y++; x++; n--;
        }
        return list;
    }
}