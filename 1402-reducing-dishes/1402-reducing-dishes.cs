public class Solution {
    public int MaxSatisfaction(int[] satisfaction) {
        Array.Sort(satisfaction);
   int maxVlaue=0;
    for(int i=0;i<satisfaction.Length;i++){
        int cook=1;
        int sum=0;
        for(int j=i;j<satisfaction.Length;j++){
        sum+=satisfaction[j]*cook;
        cook++;
        }
        maxVlaue=Math.Max(sum,maxVlaue);
    }
    return  maxVlaue;
    }
}