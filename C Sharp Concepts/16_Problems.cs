using System;

// ============================================================
//  1. SUM OF DIGITS — (LC 258 variant)
//     Given integer num, return sum of all its digits.
//     Input: 1234   Output: 10  (1+2+3+4)
//     Input: -456   Output: 15  (4+5+6)
// ============================================================
public class Solution1
{
    public int SumOfDigits(int num)
    {
        num = Math.Abs(num);        // handle negatives — ignore minus sign

        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;        // extract last digit and add to sum
            num  /= 10;             // chop off last digit
        }
        return sum;
    }
}


// ============================================================
//  2. REVERSE INTEGER — LeetCode 7
//     Reverse digits of signed 32-bit integer.
//     Return 0 if reversed number overflows int range.
//     Input:  123    Output: 321
//     Input: -456    Output: -654
//     Input:  1000   Output: 1
// =============================================================

public class Solution2
{
    public int Reverse(int x)
    {
        long rev = 0 ; 
        while(x != 0)
        {
            x = x % 10 ;
            rev = rev + x*10 ;
            x = x/10;
        }
        if (rev > int.MaxValue || rev < int.MinValue) return 0;
        return (int)rev ;
    }
}

/*

long rev = 0; // long to catch overflow before it happens
40
41 while (x != 0)
42 {
43 rev = rev * 10 + x % 10; // shift left and add last digit of x
44 x /= 10; // chop last digit off x
45 }
46
47 // int range: -2147483648 to 2147483647
48 if (rev > int.MaxValue || rev < int.MinValue) return 0;
49
50 return (int)rev;

*/



// ============================================================
//  3. PALINDROME NUMBER — LeetCode 9
//     Return true if integer reads same forwards and backwards.
//     Negative numbers are NEVER palindromes.
//     Input:  121   Output: true
//     Input: -121   Output: false
//     Input:   10   Output: false
// ============================================================
public class Solution3
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;    // -121 reversed = 121- which is invalid

        int original = x;
        int rev      = 0;

        while (x > 0)
        {
            rev = rev * 10 + x % 10;   // build reversed number digit by digit
            x  /= 10;
        }

        return original == rev;         // palindrome if original == reversed
    }
}


// ============================================================
//  4. POW(X, N) — LeetCode 50
//     Compute x raised to power n. Handle negative exponents.
//     Uses Fast Power (Binary Exponentiation) — O(log n)
//     Input: x=2.0,  n=10    Output: 1024.0
//     Input: x=2.0,  n=-2    Output: 0.25
//     Input: x=2.1,  n=3     Output: 9.261
// ============================================================
public class Solution4
{
    public double MyPow(double x, int n)
    {
        long N = n;                         // use long to safely negate int.MinValue

        if (N < 0)
        {
            x = 1.0 / x;                   // x^-n = (1/x)^n
            N = -N;
        }

        double result = 1.0;

        while (N > 0)
        {
            if (N % 2 == 1) result *= x;   // if exponent is odd → multiply once now
            x  *= x;                        // square the base  (x → x²)
            N  /= 2;                        // halve the exponent (binary trick)
        }
        // Example trace: x=2, n=10
        // N=10 (even) → x=4,  N=5
        // N=5  (odd)  → result=4,   x=16, N=2
        // N=2  (even) → x=256, N=1
        // N=1  (odd)  → result=4*256=1024, N=0 → done ✓

        return result;
    }
}


// ============================================================
//  5. PLUS ONE — LeetCode 66
//     Large number stored as digit array. Add 1 to it.
//     Input:  [1,2,3]   Output: [1,2,4]
//     Input:  [9]        Output: [1,0]
//     Input:  [9,9,9]   Output: [1,0,0,0]
// ============================================================
public class Solution5
{
    public int[] PlusOne(int[] digits)
    {
        // traverse from rightmost digit (least significant)
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;            // no carry → just increment and return
                return digits;
            }
            digits[i] = 0;             // digit was 9 → becomes 0, carry moves left
        }

        // if we're here → ALL digits were 9 (e.g. 999 → 1000)
        // need one extra digit at the front
        int[] result = new int[digits.Length + 1];
        result[0] = 1;                  // rest are already 0 by default
        return result;
    }
}


// ============================================================
//  DRIVER CODE — test all 5 solutions
// ============================================================
class Program
{
    // helper: print int[] as [x, y, z]
    static void PrintArr(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
            Console.Write(i == arr.Length - 1 ? $"{arr[i]}" : $"{arr[i]}, ");
        Console.WriteLine("]");
    }

    static void Main(string[] args)
    {
        // -------- 1. SUM OF DIGITS --------
        Solution1 s1 = new Solution1();
        Console.WriteLine("=== SUM OF DIGITS ===");
        Console.WriteLine(s1.SumOfDigits(1234));    // 10
        Console.WriteLine(s1.SumOfDigits(9999));    // 36
        Console.WriteLine(s1.SumOfDigits(-456));    // 15
        Console.WriteLine(s1.SumOfDigits(0));       // 0

        // -------- 2. REVERSE INTEGER --------
        Solution2 s2 = new Solution2();
        Console.WriteLine("\n=== REVERSE INTEGER ===");
        Console.WriteLine(s2.Reverse(123));             // 321
        Console.WriteLine(s2.Reverse(-456));            // -654
        Console.WriteLine(s2.Reverse(1000));            // 1
        Console.WriteLine(s2.Reverse(1534236469));      // 0  (overflow)

        // -------- 3. PALINDROME NUMBER --------
        Solution3 s3 = new Solution3();
        Console.WriteLine("\n=== PALINDROME NUMBER ===");
        Console.WriteLine(s3.IsPalindrome(121));    // True
        Console.WriteLine(s3.IsPalindrome(-121));   // False
        Console.WriteLine(s3.IsPalindrome(10));     // False
        Console.WriteLine(s3.IsPalindrome(1221));   // True

        // -------- 4. POW(X, N) --------
        Solution4 s4 = new Solution4();
        Console.WriteLine("\n=== POW(X, N) ===");
        Console.WriteLine(s4.MyPow(2.0, 10));      // 1024
        Console.WriteLine(s4.MyPow(2.0, -2));      // 0.25
        Console.WriteLine(s4.MyPow(2.1, 3));       // 9.261000000000001
        Console.WriteLine(s4.MyPow(1.0, 0));       // 1

        // -------- 5. PLUS ONE --------
        Solution5 s5 = new Solution5();
        Console.WriteLine("\n=== PLUS ONE ===");
        PrintArr(s5.PlusOne(new int[] { 1, 2, 3 }));   // [1, 2, 4]
        PrintArr(s5.PlusOne(new int[] { 4, 3, 2, 1 }));// [4, 3, 2, 2]
        PrintArr(s5.PlusOne(new int[] { 9 }));          // [1, 0]
        PrintArr(s5.PlusOne(new int[] { 9, 9, 9 }));   // [1, 0, 0, 0]
    }
}