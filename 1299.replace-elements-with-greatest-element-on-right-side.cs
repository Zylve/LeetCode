/*
 * @lc app=leetcode id=1299 lang=csharp
 *
 * [1299] Replace Elements with Greatest Element on Right Side
 */

// @lc code=start
// public class Solution {
//     public int[] ReplaceElements(int[] arr) {
//         int[] result = new int[arr.Length];

//         result[arr.Length - 1] = -1;

//         int max = 0;
//         int index = arr.Length - 1;

//         while(index > 0) {
//             max = Math.Max(max, arr[index]);
//             result[index - 1] = max;
//             index--;
//         }

//         return result;
//     }
// }
// @lc code=end
