/*
 * @lc app=leetcode id=383 lang=csharp
 *
 * [383] Ransom Note
 */

// @lc code=start

// public class Solution {
//     public bool CanConstruct(string ransomNote, string magazine) {
//         Dictionary<char, int> dict = new Dictionary<char, int>();
//         foreach(char c in magazine) {
//             int count = dict.GetValueOrDefault(c, 0);
//             dict[c] = count + 1;
//         }

//         foreach(char c in ransomNote) {
//             int count = dict.GetValueOrDefault(c, 0);

//             if(count == 0) {
//                 return false;
//             }

//             dict[c]--;
//         }

//         return true;
//     }
// }
// @lc code=end
