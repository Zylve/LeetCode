/*
 * @lc app=leetcode id=94 lang=csharp
 *
 * [94] Binary Tree Inorder Traversal
 */
// public class TreeNode {
//     public int val;
//     public TreeNode? left;
//     public TreeNode? right;
//     public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null) {
//         this.val = val;
//         this.left = left;
//         this.right = right;
//     }
// }
// @lc code=start
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
// public class Solution {
//     private readonly List<int> l = new List<int>();
//     public IList<int> InorderTraversal(TreeNode root) {
//         Traverse(root);
//         return l;
//     }

//     public void Traverse(TreeNode? node) {
//         if(node == null) {
//             return;
//         }

//         Traverse(node.left);
//         l.Add(node.val);
//         Traverse(node.right);
//     }
// }
// @lc code=end
