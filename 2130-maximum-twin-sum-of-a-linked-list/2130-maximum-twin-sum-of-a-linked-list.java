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
    public int pairSum(ListNode head) {
        int max = 0;
        var list = new ArrayList<Integer>();
        while (head != null){
            list.add(head.val);
            head = head.next;
        }
        int n = list.size();
        for (int i = 0 ; i < n/2 ; i++){
            int temp = list.get(i) + list.get(n - 1 - i);
            if (temp > max)
                max = temp;
        }
        return max;
    }
}