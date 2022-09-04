/*
 * @lc app=leetcode id=977 lang=csharp
 *
 * [977] Squares of a Sorted Array
 */

// @lc code=start
// public class Solution {
//     public int[] SortedSquares(int[] nums) {
//         int[] arr = new int[nums.Length];
//         for(int i = 0; i < nums.Length; i++) {
//             arr[i] = nums[i] * nums[i];
//         }

//         MergeSort(arr);

//         return arr;
//     }

//     public void MergeSort(int[] array) {
//         int length = array.Length;
//         if(length <= 1) { return; }

//         int middle = length / 2;
//         int[] leftArray = new int[middle];
//         int[] rightArray = new int[length - middle];

//         int i = 0;
//         int j = 0;

//         for(; i < length; i++) {
//             if(i < middle) {
//                 leftArray[i] = array[i];
//             } else {
//                 rightArray[j] = array[i];
//                 j++;
//             }
//         }

//         MergeSort(leftArray);
//         MergeSort(rightArray);
//         Merge(leftArray, rightArray, array);
//     }

//     public void Merge(int[] leftArray, int[] rightArray, int[] array) {
//         int leftLength = array.Length / 2;
//         int rightLength = array.Length - leftLength;

//         int i = 0;
//         int l = 0;
//         int r = 0;

//         while(l < leftLength && r < rightLength) {
//             if(leftArray[l] < rightArray[r]) {
//                 array[i] = leftArray[l];
//                 i++;
//                 l++;
//             } else {
//                 array[i] = rightArray[r];
//                 i++;
//                 r++;
//             }
//         }

//         while(l < leftLength) {
//             array[i] = leftArray[l];
//             i++;
//             l++;
//         }

//         while(r < rightLength) {
//             array[i] = rightArray[r];
//             i++;
//             r++;
//         }
//     }
// }
// @lc code=end
