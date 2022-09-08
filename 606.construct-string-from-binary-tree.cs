/*
 * @lc app=leetcode id=606 lang=csharp
 *
 * [606] Construct String from Binary Tree
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
// // @lc code=start
// /**
//  * Definition for a binary tree node.
//  * public class TreeNode {
//  *     public int val;
//  *     public TreeNode left;
//  *     public TreeNode right;
//  *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
//  *         this.val = val;
//  *         this.left = left;
//  *         this.right = right;
//  *     }
//  * }
//  */
// public class Solution {
//     public string Tree2str(TreeNode root) {
//         return Traverse(root);
//     }

//     private string Traverse(TreeNode node) {
//         if(node == null) {
//             return "";
//         }

//         if(node.left == null && node.right == null) {
//             return node.val.ToString();
//         }

// #pragma warning disable CS8604
//         string left = $"({Traverse(node.left)})";
//         string right = Traverse(node.right);
// #pragma warning restore CS8604

//         right = (right?.Length == 0) ? "" : $"({right})";

//         return $"{node.val}{left}{right}";
//     }
// }

// @lc code=end
