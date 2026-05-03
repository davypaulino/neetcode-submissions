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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 is null)
            return list2;
        if (list2 is null)
            return list1;

        var res = new ListNode();
        var backup = res;
        while (list1 is not null && list2 is not null) {
            if (list1.val <= list2.val) {
                backup.next = list1;
                list1 = list1.next;
                backup = backup.next;
                continue;
            }
            backup.next = list2;
            list2 = list2.next;
            backup = backup.next;
        }
        backup.next = list1 is not null ? list1 : list2;
        return res.next;
    }
}