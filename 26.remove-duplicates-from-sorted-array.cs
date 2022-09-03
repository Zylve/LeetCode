/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
// public class Solution {
//     public int RemoveDuplicates(int[] nums) {
//         for(int i = 0; i < nums.Length; i++) {
//             for(int j = i + 1; j < nums.Length; j++) {
//                 if(nums[i] == nums[j]) {
//                     nums[j] = 150;
//                 }
//             }
//         }

//         for(int i = 0; i < nums.Length; i++) {
//             if(nums[i] == 150) {
//                 bool swapped = false;
//                 for(int j = i + 1; j < nums.Length; j++) {
//                     if(!swapped && nums[j] != 150) {
//                         int t = nums[j];
//                         nums[j] = nums[i];
//                         nums[i] = t;
//                         swapped = true;
//                     }
//                 }
//             }
//         }

//         for(int i = 0; i < nums.Length; i++) {
//             if(nums[i] == 150) {
//                 return i;
//             }
//         }

//         return nums.Length;
//     }
// }
// @lc code=end
