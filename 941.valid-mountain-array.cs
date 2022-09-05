/*
 * @lc app=leetcode id=941 lang=csharp
 *
 * [941] Valid Mountain Array
 */

// @lc code=start
// public class Solution {
//     public bool ValidMountainArray(int[] arr) {
//         int max = 0;
//         int peak = 0;

//         for(int i = 0; i < arr.Length; i++) {
//             if(arr[i] > max) {
//                 max = arr[i];
//                 peak = i;
//             }
//         }

//         if(peak == 0 || peak == arr.Length - 1) {
//             return false;
//         }

//         for(int i = 0; i < peak; i++) {
//             if(arr[i] >= arr[i + 1]) {
//                 return false;
//             }
//         }

//         for(int i = peak; i < arr.Length - 1; i++) {
//             if(arr[i] <= arr[i + 1]) {
//                 return false;
//             }
//         }

//         return true;
//     }
// }
// @lc code=end
