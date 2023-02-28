/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
public:
    map<string,int> mp;
    vector<TreeNode *> res;

    string traverse(TreeNode *root){
        if(!root) return "";

        string left = traverse(root->left);
        string right = traverse(root->right);

        string curr = to_string(root->val) + " " + left + " " + right;

        if(mp[curr] == 1){
            res.push_back(root);
        }
        mp[curr]++;
        return curr;
    }
    vector<TreeNode*> findDuplicateSubtrees(TreeNode* root) {
        string dumb = traverse(root);
        return res;
    }
};