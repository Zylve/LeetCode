/*
 * @lc app=leetcode id=414 lang=csharp
 *
 * [414] Third Maximum Number
 */

// @lc code=start
// public class Solution {
//     public int ThirdMax(int[] nums) {
//         Array.Sort(nums);
//         int i = nums[0];
//         int j = nums[0];
//         int k = nums[0];

//         HashSet<int> set = new HashSet<int>(nums);

//         if(set.Count < 3) {
//             return nums.Max();
//         }

//         foreach(int l in set) {
//             if(l > i) {
//                 k = j;
//                 j = i;
//                 i = l;
//             }
//         }

//         return k;
//     }
// }
// @lc code=end
