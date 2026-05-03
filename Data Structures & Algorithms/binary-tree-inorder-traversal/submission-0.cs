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
    public List<int> InorderTraversal(TreeNode root) {
        List<int> list = new();
        Inorder(root, ref list);
        return list;
    }

    private void Inorder(TreeNode root, ref List<int> list) {
        if (root is null)
            return;

        Inorder(root.left, ref list);
        list.Add(root.val);
        Inorder(root.right, ref list);
    }
}