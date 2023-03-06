class Solution {
public:
    int findKthPositive(vector<int>& arr, int k) {
        int counter = 0, val = 1, idx = 0;
        while(counter < k){
            if (idx < arr.size() && arr[idx] == val) {
                idx++;
                val++;
            }
            else{
                counter++;
                if (counter == k) return val;
                val++;
            }
        }
        return 0;
    }
};