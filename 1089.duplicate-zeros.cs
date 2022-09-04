/*
 * @lc app=leetcode id=1089 lang=csharp
 *
 * [1089] Duplicate Zeros
 */

// @lc code=start
// public class Solution {
//     public void DuplicateZeros(int[] arr) {
//         int length = arr.Length;

//         for(int i = 0; i < length && i + 1 < length; i++) {
//             if(arr[i] == 0) {
//                 for(int j = length - 1; j >= i; j--) {
//                     if(j + 1 < length) {
//                         arr[j + 1] = arr[j];
//                     }
//                 }
//                 i++;
//             }
//         }
//     }
// }
// @lc code=end
