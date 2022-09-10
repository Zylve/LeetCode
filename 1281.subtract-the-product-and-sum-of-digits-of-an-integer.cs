/*
 * @lc app=leetcode id=1281 lang=csharp
 *
 * [1281] Subtract the Product and Sum of Digits of an Integer
 */

// @lc code=start
// public class Solution {
//     public int SubtractProductAndSum(int n) {
//         string s = n.ToString();

//         int pro = 1;
//         int sum = 0;

//         for(int i = 0; i < s.Length; i++) {
//             pro *= int.Parse(s[i].ToString());
//             sum += int.Parse(s[i].ToString());
//         }

//         return pro - sum;
//     }
// }
// @lc code=end
