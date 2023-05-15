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
    public ListNode swapNodes(ListNode head, int k) {
        var tmp = head;
        int cnt = 1, val=0, val2 = 0;
        while (tmp != null){
            if (cnt == k)
                val = tmp.val;
            cnt++;
            tmp=tmp.next;
            
        }
        int kk = cnt-k;
        cnt = 1;
        tmp = head;
        while (tmp != null){
            if (cnt == kk){
                val2 = tmp.val;
                tmp.val = val;
            }
            cnt++;
            tmp=tmp.next;
        }
        cnt = 1;
        tmp = head;
        while (tmp != null){
            if (cnt == k){
                tmp.val = val2;
            }
            cnt++;
            tmp=tmp.next;
        }
        return head;
    }
}