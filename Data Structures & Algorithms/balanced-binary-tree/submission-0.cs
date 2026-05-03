/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
public bool IsBalanced(TreeNode root) {
        if (root == null) return true;
        
        return GetDetails(root).isBalanced;
    }

    private (int height, bool isBalanced) GetDetails(TreeNode node) {
        if (node == null)
            return (0, true);

        var left = GetDetails(node.left);
        var right = GetDetails(node.right);

        int currentHeight = Math.Max(left.height, right.height) + 1;
        bool currentBalanced = left.isBalanced && 
                               right.isBalanced && 
                               Math.Abs(left.height - right.height) <= 1;

        return (currentHeight, currentBalanced);
    }
}
