public class Solution {
    public int FindPermutationDifference(string s, string t) {
            int sum = 0;
            int diff = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int index = t.IndexOf(s[i]); 
                diff = Math.Abs(i - index);
                sum += diff;

            }

            return sum;
}}