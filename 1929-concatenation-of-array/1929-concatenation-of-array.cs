public class Solution {
    public int[] GetConcatenation(int[] nums) {
         int n = nums.Length * 2;
        int[] ans = new int[n];


        for (int i = 0, j = 0; i < n; i++)
        {
            if (j >= nums.Length)
            {
                j = 0;
            }
            ans[i] = nums[j];
            j++;
        }

        return ans;
    }
    }
