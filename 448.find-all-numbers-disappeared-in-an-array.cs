/*
 * @lc app=leetcode id=448 lang=csharp
 *
 * [448] Find All Numbers Disappeared in an Array
 */

// @lc code=start
// public class Solution {
//     public IList<int> FindDisappearedNumbers(int[] nums) {
//         for(int i = 0; i < nums.Length; i++) {
//             int j = Math.Abs(nums[i]) - 1;

//             if(nums[j] > 0) {
//                 nums[j] = -nums[j];
//             }
//         }

//         List<int> l = new List<int>();

//         for(int i = 0; i < nums.Length; i++) {
//             if(nums[i] > 0) {
//                 l.Add(i + 1);
//             }
//         }
//         return l;
//     }
// }
// @lc code=end
