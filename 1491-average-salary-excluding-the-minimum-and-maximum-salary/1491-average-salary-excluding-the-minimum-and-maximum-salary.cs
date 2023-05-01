public class Solution {
    public double Average(int[] salary) {
        Array.Sort(salary);
        int sum = 0;
        for (int i = 1 ; i < salary.Length-1 ; i++)
            sum += salary[i];
        return (double)sum/(salary.Length - 2);
    }
}