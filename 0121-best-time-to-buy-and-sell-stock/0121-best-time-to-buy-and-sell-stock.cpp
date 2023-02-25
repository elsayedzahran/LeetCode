class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int res=0,cur=prices[0];
        for (int i = 0; i < prices.size(); i++)
        {
            res = max(res,prices[i]-cur);
            cur = min(cur,prices[i]);
        }
        return res;
    }
};