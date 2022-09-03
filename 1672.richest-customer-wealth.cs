/*
 * @lc app=leetcode id=1672 lang=csharp
 *
 * [1672] Richest Customer Wealth
 */

// @lc code=start
// public class Solution {
//     public int MaximumWealth(int[][] accounts) {
//         int richest = 0;
//         foreach(int[] i in accounts) {
//             int wealth = 0;
//             foreach(int j in i) {
//                 wealth += j;
//             }

//             if(wealth >= richest) {
//                 richest = wealth;
//             }
//         }

//         return richest;
//     }
// }
// @lc code=end
