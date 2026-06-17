using System;
using System.Linq;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)    // Loop starts from last digits to first
        {
            if (digits[i] < 9)                          // if digit is smaller than 9
            {
                digits[i]++;                            // add 1 to that digit
                return digits;                          // then return it 
            }
            digits[i] = 0;                              // otherwise if number is 9 , make it 0 , repeat process
        }


        // if no number not returned after above loop , it must contain all digits '9' eg.999 , 99 , etc.
        int[] result = new int[digits.Length + 1];      // create new array with length of input array + 1
        // when we create new result array it contains all elements 0       [eg. result = [0,0,0,0,0,0] ]
        result[0] = 1;                                  // then make 1st element as 1 
        return result;                                  // return whole result array 
    }
}

// Time Complexity: O(N)
// Space Complexity: O(1)