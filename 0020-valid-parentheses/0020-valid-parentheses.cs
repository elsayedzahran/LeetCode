public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<int>();
        foreach (var ch in s){
            if (ch == '(' || ch == '[' || ch == '{')
                stack.Push(ch);
            else{
                if (stack.Count == 0)
                    return false;
                else{
                    if (ch == ']' && stack.Peek() == '[')
                        stack.Pop();
                    else if (ch == '}' && stack.Peek() == '{')
                        stack.Pop();
                    else if (ch == ')' && stack.Peek() == '(')
                        stack.Pop();
                    else 
                        return false;
                }
            }
        }
        if (stack.Count > 0)
            return false;
        return true;
    }
}