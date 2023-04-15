public class Solution {
    public int MaxValueOfCoins(IList<IList<int>> piles, int k) {
        int[] mv = new int[k + 1];
		int[] pileSum = new int[k + 1];
        
		foreach (var pile in piles) {
			int n = Math.Min(k, pile.Count);
			int sum = 0;
			for (int i = 1; i <= n; i++)
				pileSum[i] = sum += pile[i - 1];
			for (int i = k; i > 0; i--) {
				int max = 0;
				for (int j = Math.Min(i, n); j >= 0; j--)
					max = Math.Max(max, pileSum[j] + mv[i - j]);
				mv[i] = max;
			}
		}
		return mv[k];
    }
}