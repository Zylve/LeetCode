/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
// public class Solution {
//     public int RemoveElement(int[] nums, int val) {
//         int wp = 0;

//         for(int i = 0; i < nums.Length; i++) {
//             if(nums[i] != val) {
//                 (nums[wp], nums[i]) = (nums[i], nums[wp]);
//                 wp++;
//             }
//         }

//         return wp;
//     }
// }
// @lc code=end
