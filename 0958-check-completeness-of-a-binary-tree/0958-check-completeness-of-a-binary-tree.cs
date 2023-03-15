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
    public bool IsCompleteTree(TreeNode root) {
        var queue =new Queue<TreeNode>();
        
        queue.Enqueue(root);
        while (queue.Peek() != null){
            var node = queue.Dequeue();
            queue.Enqueue(node.left);
            queue.Enqueue(node.right);
        }
        while (queue.Count() > 0 && queue.Peek() == null)
            queue.Dequeue();
        return queue.Count == 0;
    }
}