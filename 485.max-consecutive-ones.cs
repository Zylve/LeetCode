/*
 * @lc app=leetcode id=485 lang=csharp
 *
 * [485] Max Consecutive Ones
 */

// @lc code=start
// public class Solution {
//     public int FindMaxConsecutiveOnes(int[] nums) {
//         int n = nums.Length;
//         int count = 0;
//         int max = int.MinValue;
//         for(int i = 0; i < n; i++) {
//             if(nums[i] == 0) {
//                 if(count > max) {
//                     max = count;
//                 }

//                 count = 0;
//             } else {
//                 count++;
//             }
//         }

//         if(count > max) {
//             max = count;
//         }
//         return max;
//     }
// }
// @lc code=end
