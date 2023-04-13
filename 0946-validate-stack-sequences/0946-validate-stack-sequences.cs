public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        Stack<int> st = new Stack<int>();
        int i = 0;
        foreach (int num in pushed){
            st.Push(num);
            while (st.Count > 0 && st.Peek() == popped[i]) {
                st.Pop();
                i++;
            }
        }
        return st.Count == 0 ? true : false;
    }
}
