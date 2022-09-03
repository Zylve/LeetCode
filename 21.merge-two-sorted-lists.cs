/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
 */

// public class ListNode {
//     public int val;
//     public ListNode? next;
//     public ListNode(int val = 0, ListNode? next = null) {
//         this.val = val;
//         this.next = next;
//     }
// }

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
// public class Solution {
//     public ListNode MergeTwoLists(ListNode? list1, ListNode? list2) {

//         if(list1 == null) {
//             return list2;
//         }

//         if(list2 == null) {
//             return list1 ;
//         }

//         if(list1.val <= list2.val) {
//             list1.next = MergeTwoLists(list1.next, list2);
//             return list1;
//         } else {
//             list2.next = MergeTwoLists(list1, list2.next);
//             return list2;
//         }

// bool reachedEnd = false;
// ListNode head;
// int traverse = 1;

// if(list1.val <= list2.val) {
//     head = list1;
//     if(list1.next == null) {
//         reachedEnd = true;
//     } else {
//         list1 = list1.next;
//     }
// } else {
//     head = list2;
//     if(list2.next == null) {
//         reachedEnd = true;
//     } else {
//         list2 = list2.next;
//     }
// }

// if(list1.next == null || list2.next == null) {
//     reachedEnd = true;
// }

// while(!reachedEnd) {
//     ListNode t = list1;
//     for(int i = 0; i < traverse; i++) {
//         t
//     }
// }

// return null;
//     }
// }
// @lc code=end
