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
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head is null)
            return head;

        ListNode? next = head.next;
        ListNode? before = null;
        while (head is not null) {
            head.next = before;
            before = head;
            head = next;
            if (next is not null) {
                next = next.next;
            }
        }
        return before;
    }
}
