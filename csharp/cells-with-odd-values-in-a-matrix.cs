public class Solution {
    public int OddCells(int n, int m, int[][] indices) {
        int numberOfOddCells = 0;
        int[,] matrix = new int[n,m];
        for (int i = 0; i < indices.Length; i++)
        {
            int rowToIncrement = indices[i][0];
            int columnToIncrement = indices[i][1];
            for (int j = 0; j < m; j++)
            {
                matrix[rowToIncrement,j]++;
            }
            for (int k = 0; k < n; k++)
            {
                matrix[k,columnToIncrement]++;
            }
        }
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (matrix[i,j] % 2 == 1) {
                    numberOfOddCells++;
                }
            }
        }
        return numberOfOddCells;
    }
}
