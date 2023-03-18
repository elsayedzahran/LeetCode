public class BrowserHistory {
    Stack<string> back;
    Stack<string> forward;
    string curr;
    public BrowserHistory(string homepage) {
        back = new Stack<string>();
        forward = new Stack<string>(); 
        curr = homepage;
    }
    
    public void Visit(string url) {
        back.Push(curr);
        curr = url;
        forward = new Stack<string>();
    }
    
    public string Back(int steps) {
        while (steps-- > 0 && back.Count() > 0){
            forward.Push(curr);
            curr = back.Pop();
        }
        return curr;
    }
    
    public string Forward(int steps) {
        while (steps--  > 0 && forward.Count() > 0){
            back.Push(curr);
            curr = forward.Pop();
        }
        return curr;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */