/*
 * @lc app=leetcode id=1346 lang=csharp
 *
 * [1346] Check If N and Its Double Exist
 */

// @lc code=start
// public class Solution {
//     public bool CheckIfExist(int[] arr) {
//         HashSet<int> set = new HashSet<int>();
//         int n = 0;

//         for(int i = 0; i < arr.Length; i++) {
//             if(arr[i] == 0) {
//                 n++;

//                 if(n > 1) {
//                     return true;
//                 } else {
//                     continue;
//                 }
//             }

//             set.Add(arr[i]);
//         }

//         for(int i = 0; i < arr.Length; i++) {
//             if(set.Contains(arr[i] * 2) || (arr[i] % 2 == 0 && set.Contains(arr[i] / 2))) {
//                 return true;
//             }
//         }

//         return false;
//     }
// }
// @lc code=end
