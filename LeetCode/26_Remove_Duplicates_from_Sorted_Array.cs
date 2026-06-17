using System;
using System.Linq;

public class Solution {
    public int RemoveDuplicates(int[] nums) {
       int k = 1;
       if (nums.Length == 0) return 0;
        for(int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[k] = nums[i];
                ++k;
            }
        }
        return k;
    }
}

// Time Complexity: O(N)
// Space Complexity: O(1)
