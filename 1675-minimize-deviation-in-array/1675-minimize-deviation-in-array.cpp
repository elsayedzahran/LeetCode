class Solution {
public:
    int minimumDeviation(vector<int>& nums) {

        if (nums.empty())
            return INT_MAX;

        priority_queue<int> even;
        int min_val = INT_MAX;

        for (int num : nums) 
        {
            int temp;
            if (num % 2 == 0) 
                temp = num;
            else 
                temp = num*2;

            even.push(temp);
            min_val = min(temp , min_val);
        }

        int res = INT_MAX;
        while (even.top() % 2 == 0) {
            int max_val = even.top();
            even.pop();
            res = min(res, max_val - min_val);
            int num = max_val / 2;
            even.push(num);
            min_val = min(min_val, num);
        }

        res = min(even.top() - min_val, res);
        return res;
    }
};