/*
 * @lc app=leetcode id=876 lang=csharp
 *
 * [876] Middle of the Linked List
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
//     public ListNode? MiddleNode(ListNode head) {
//         ListNode? m = head;
//         ListNode? t = head;

//         while(t?.next != null) {
//             m = m?.next;
//             t = t.next.next;
//         }

//         return m;
//     }
// }
// @lc code=end
