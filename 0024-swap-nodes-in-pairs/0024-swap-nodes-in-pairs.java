/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode swapPairs(ListNode head) {
        if (head == null || head.next == null)
            return head;
        var temp1 = head.next;
        var temp2 = head;
        while (temp1 != null){
            int val = temp2.val;
            temp2.val = temp1.val;
            temp1.val = val;
            int i = 2;
            while (temp1 != null && i-- > 0){
                temp1 = temp1.next;
                temp2 = temp2.next;
            }
        }
        return head;
    }
}