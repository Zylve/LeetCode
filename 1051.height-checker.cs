/*
 * @lc app=leetcode id=1051 lang=csharp
 *
 * [1051] Height Checker
 */

// @lc code=start
// public class Solution {
//     public int HeightChecker(int[] heights) {
//         int[] expected = new int[heights.Length];
//         Array.Copy(heights, expected, heights.Length);
//         Array.Sort(expected);

//         int n = 0;

//         for(int i = 0; i < heights.Length; i++) {
//             if(expected[i] != heights[i]) {
//                 n++;
//             }
//         }

//         return n;
//     }
// }
// @lc code=end
