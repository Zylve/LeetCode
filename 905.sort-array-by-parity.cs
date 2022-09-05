/*
 * @lc app=leetcode id=905 lang=csharp
 *
 * [905] Sort Array By Parity
 */

// @lc code=start
// public class Solution {
//     public int[] SortArrayByParity(int[] nums) {
//         int wp = 0;

//         for(int i = 0; i < nums.Length; i++) {
//             if(nums[i] % 2 == 0) {
//                 (nums[wp], nums[i]) = (nums[i], nums[wp]);
//                 wp++;
//             }
//         }

//         return nums;
//     }
// }
// @lc code=end
