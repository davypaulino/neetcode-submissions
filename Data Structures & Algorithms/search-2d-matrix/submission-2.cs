public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if (matrix.Length == 0 || matrix[0].Length == 0) return false;
        int top = 0, bottom = matrix.Length - 1;
        int left = 0, right = matrix[0].Length - 1;

        while (top <= bottom && left <= right) {
            int yMiddle = top + (bottom - top) / 2;
            int xMiddle = left + (right - left) / 2;

            if (target > matrix[yMiddle][xMiddle]) {
                if (target > matrix[yMiddle][right]) {
                    top = yMiddle + 1;
                } else {
                    left = xMiddle + 1;
                }
            } else if (target < matrix[yMiddle][xMiddle]) {
                if (target < matrix[yMiddle][left]) {
                    bottom = yMiddle - 1;
                } else {
                    right = xMiddle -1;
                }
            } else if (target == matrix[yMiddle][xMiddle]) {
                return true;
            }
        }
        return false;
    }
}
