using System;

public class Solution
{
    public int Reverse(int x)
    {
        long rev = 0;

        while (x != 0)
        {
            if (rev > int.MaxValue / 10 || rev < int.MinValue / 10)
                return 0;

            rev = rev * 10 + x % 10;
            x = x / 10;
        }

        return (int)rev;
    }
}

// Time Complexity: O(log10(N))
// Space Complexity: O(1)