class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int res=0,cur=prices[0];
        for (auto i : prices)
        {
            res = max(res,i-cur);
            cur = min(cur,i);
        }
        return res;
    }
};