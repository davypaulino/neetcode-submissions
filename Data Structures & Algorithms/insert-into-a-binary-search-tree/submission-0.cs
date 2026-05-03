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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        return InsertIntoBST(root, val, true);
    }

    private TreeNode InsertIntoBST(TreeNode root, int val, bool insert) {
        if (root == null) {
            return insert ? new(val: val) : null;
        }
            
        TreeNode newRoot = new(val: root.val);
        newRoot.left = InsertIntoBST(root.left, val, val < root.val && insert);
        newRoot.right = InsertIntoBST(root.right, val, val > root.val && insert);
        return newRoot;
    }
}