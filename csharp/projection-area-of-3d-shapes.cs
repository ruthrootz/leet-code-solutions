public class Solution {
    public int ProjectionArea(int[][] grid) {
        int total = 0;
        int rowCount = grid.Length;
        for (int i = 0; i < rowCount; i++) {
            for (int j = 0; j < rowCount; j++) {
                if (grid[i][j] > 0) {
                    total++;
                }
            }
        }
        for (int i = 0; i < rowCount; i++) {
            int maxLeftValue = grid[i][0];
            int maxRightValue = grid[0][i];
            for (int j = 0; j < rowCount; j++){
                if (grid[i][j] > maxLeftValue) {
                    maxLeftValue = grid[i][j];
                }
                if (grid[j][i] > maxRightValue){
                    maxRightValue = grid[j][i];
                }
            }
            total += maxLeftValue;
            total += maxRightValue;
        }
        return total;
    }
}
