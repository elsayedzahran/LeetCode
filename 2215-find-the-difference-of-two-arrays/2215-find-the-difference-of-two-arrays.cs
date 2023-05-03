public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var result = new List<IList<int>>();
        
        var set = new HashSet<int>(nums1);
        for (int i = 0; i < nums2.Length; i++) set.Remove(nums2[i]);
        result.Add(set.ToList());
        
        set = new HashSet<int>(nums2);
        for (int i = 0; i < nums1.Length; i++) set.Remove(nums1[i]);
        result.Add(set.ToList());
        
        return result;
        
    }
}