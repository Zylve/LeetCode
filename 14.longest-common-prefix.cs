/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
// public class Solution {
//     public string LongestCommonPrefix(string[] strs) {
//         if(strs.Length == 1) {
//             return strs[0];
//         }

//         string cPre = "";

//         for(int i = 0; i < strs[0].Length; i++) {
//             foreach(string str in strs) {
//                 if(i > str.Length - 1) {
//                     return cPre;
//                 }

//                 if(strs[0][i] != str[i]) {
//                     return cPre;
//                 }
//             }

//             cPre += strs[0][i];
//         }

//         return cPre;
//     }
// }
// @lc code=end
