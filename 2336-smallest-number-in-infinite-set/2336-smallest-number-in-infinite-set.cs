public class SmallestInfiniteSet {
    PriorityQueue<int, int> obj;
    int idx = 1;
    public SmallestInfiniteSet() {
        obj = new PriorityQueue<int, int>();
        idx = 1;
    }
    
    public int PopSmallest() {
        if(obj.Count > 0){
            int min = obj.Peek();
            while(obj.Count > 0 && obj.Peek() == min)
                obj.Dequeue();
            return min;
        }

        return idx++;
    }
    
    public void AddBack(int num) {
        if (idx <= num)
            return;
        obj.Enqueue(num,num);
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */