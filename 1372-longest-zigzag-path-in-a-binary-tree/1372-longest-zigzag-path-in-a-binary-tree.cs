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
    public int maxLength=0;
    public int LongestZigZag(TreeNode root) {
        solve(root,0,0);
        solve(root,1,0);
        return maxLength;
    }
    public void solve(TreeNode root,int dir,int currLength){
        if(root == null) 
            return;
        maxLength=Math.Max(maxLength,currLength);
        if(dir==1){
            solve(root.left,0,currLength+1);
            solve(root.right,1,1);
        }
        else{
            solve(root.right,1,currLength+1);
            solve(root.left,0,1);
        }
    }
}