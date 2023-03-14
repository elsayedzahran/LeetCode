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
    int sum = 0;
    public int SumNumbers(TreeNode root) {
        if (root == null)
            return 0;
        DFS(root, 0);  
        return sum;
    }
    void DFS (TreeNode node, int prev)
    {
        if (node.left == null && node.right == null)
            sum += prev * 10 + node.val;
        else
        {
            if (node.left != null)
                DFS(node.left, prev * 10 + node.val);
            
            if (node.right != null)
                DFS(node.right, prev * 10 + node.val);
        }
    }
}