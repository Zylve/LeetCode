/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
// public class Solution {
//     public const int M = 1000;
//     public const int D = 500;
//     public const int C = 100;
//     public const int L = 50;
//     public const int X = 10;
//     public const int V = 5;
//     public const int I = 1;

//     public bool IsBefore(string s, int i, char[] arr) {
//         if(i == s.Length - 1) {
//             return false;
//         }

//         foreach(char c in arr) {
//             if(s[i + 1] == c) {
//                 return true;
//             }
//         }

//         return false;
//     }

//     public int RomanToInt(string s) {
//         int total = 0;

//         for(int i = 0; i < s.Length; i++) {
//             switch(s[i]) {
//                 case 'M':
//                     total += M;
//                     break;
//                 case 'D':
//                     total += D;
//                     break;
//                 case 'C':
//                     if(IsBefore(s, i, new char[2] { 'M', 'D' })) {
//                         total -= C;
//                     } else {
//                         total += C;
//                     }
//                     break;
//                 case 'L':
//                     total += L;
//                     break;
//                 case 'X':
//                     if(IsBefore(s, i, new char[2] { 'C', 'L' })) {
//                         total -= X;
//                     } else {
//                         total += X;
//                     }
//                     break;
//                 case 'V':
//                     total += V;
//                     break;
//                 case 'I':
//                     if(IsBefore(s, i, new char[2] { 'X', 'V' })) {
//                         total -= I;
//                     } else {
//                         total += I;
//                     }
//                     break;
//             }
//         }

//         return total;
//     }
// }
// @lc code=end
