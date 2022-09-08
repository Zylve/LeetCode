/*
 * @lc app=leetcode id=707 lang=csharp
 *
 * [707] Design Linked List
 */

// @lc code=start
// public class MyLinkedList {
//     private Node? head;
//     public int Get(int index) {
//         if(head == null) {
//             return -1;
//         }

//         Node it = head;

//         for(int i = 0; i < index; i++) {
//             if(it.Next == null) {
//                 return -1;
//             }
//         }

//         return it.Val;
//     }

//     public void AddAtHead(int val) {
//         this.head = new Node(val, this.head);
//     }

//     public void AddAtTail(int val) {
//         if(this.head == null) {
//             this.head = new Node(val);
//             return;
//         }

//         bool reachedEnd = false;
//         Node? it = head;

//         while(!reachedEnd) {
//             it = it?.Next;
//             if(it?.Next == null) {
//                 reachedEnd = true;
//             }
//         }

//         if(it != null) {
//             it.Next = new Node(val);
//         }
//     }

//     public void AddAtIndex(int index, int val) {
//         if(head == null) {
//             AddAtHead(val);
//         }

//         Node it = head;
//         for(int i = 0; i < index; i++) {
//             if()
//         }
//     }

//     public void DeleteAtIndex(int index) {

//     }
// }

// public class Node {
//     public int Val;
//     public Node? Next;

//     public Node(int val, Node? next = null) {
//         this.Val = val;
//         this.Next = next;
//     }
// }

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */
// @lc code=end
