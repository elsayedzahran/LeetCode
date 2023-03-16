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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        return Solve(0, inorder.Length - 1, 0, postorder.Length - 1, inorder, postorder);
        
    }
    TreeNode Solve(int inStart, int inEnd, int postStart, int postEnd, int[] inorder, int[] postorder) {
            if (inStart > inEnd || postStart > postEnd) 
                return null;

            TreeNode node = new TreeNode(postorder[postEnd]);
            if (postStart != postEnd) {
                
                int leftNodesCount = 0;
                while (inorder[inStart + leftNodesCount] != postorder[postEnd])
                    leftNodesCount++;
                
                node.left = Solve(
                    inStart, inStart+leftNodesCount-1, postStart, postStart+leftNodesCount-1 , inorder , postorder);
                node.right = Solve(
                    inStart + leftNodesCount +1, inEnd, postStart+leftNodesCount, postEnd -1 , inorder, postorder);
            }
            return node;
        }
}