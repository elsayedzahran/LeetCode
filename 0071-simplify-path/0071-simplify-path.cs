public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> st = new Stack<string>();
        path = path.Replace("//", "/").TrimEnd('/');

        foreach (string s in path.Split('/', StringSplitOptions.RemoveEmptyEntries))
        {
            if (s == ".." && st.Count > 0)
                st.Pop();
            else if (s == "." || s == "..")
                continue;
            else
                st.Push(s);
        }

        StringBuilder sb = new StringBuilder();

        while (st.Count > 0)
        {
            sb.Insert(0, "/" + st.Pop());
        }

        if (sb.Length == 0)
            sb.Append("/");

        return sb.ToString();
    }
}