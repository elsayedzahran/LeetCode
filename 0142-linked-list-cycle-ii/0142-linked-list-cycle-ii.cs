/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        ListNode temp1 = head, temp2 = head;
        while (temp2 != null && temp2.next != null) {
            temp1 = temp1.next;
            temp2 = temp2.next.next;
            if (temp1 == temp2) break;
        }
        if (temp2 == null || temp2.next == null) return null;
        while (head != temp1) {
            head = head.next;
            temp1 = temp1.next;
        }
        return head;
    }
}