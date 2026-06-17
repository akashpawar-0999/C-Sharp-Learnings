using System;
using System.Collections.Generic;

namespace Problems18Explanation
{
// ============================================================
//  EASY 1 — COUNT EVEN DIGITS
//
//  Given an integer, count how many of its digits are even.
//  Even digits are: 0, 2, 4, 6, 8
//
//  Examples:
//  Input:  1234   Output: 2   →  2 and 4 are even
//  Input:  9999   Output: 0   →  no even digits at all
//  Input:  2468   Output: 4   →  all four digits are even
//  Input:  -246   Output: 3   →  ignore the minus sign, 2, 4, 6 are even
//
// ============================================================
public class Solution1
{
    public int CountEvenDigits(int num)
    {
        // write your solution here
        throw new NotImplementedException();
    }
}


// ============================================================
//  EASY 2 — IS POWER OF THREE
//
//  Return true if n is a power of 3  (3^0=1, 3^1=3, 3^2=9, 3^3=27 …)
//  Any value that is 0 or negative is always false.
//
//  Examples:
//  Input:   1   Output: true   →  3^0 = 1
//  Input:   9   Output: true   →  3^2 = 9
//  Input:  27   Output: true   →  3^3 = 27
//  Input:  10   Output: false  →  10 is not a power of 3
//  Input:   0   Output: false  →  0 is never a power of 3
//
//  How to think about it:
//  Step 1 — If n <= 0, return false immediately.
//  Step 2 — While n is divisible by 3 (n % 3 == 0), divide n by 3.
//  Step 3 — After the loop, if n equals 1 it was a pure power of 3 → return true.
//           If anything other than 1 remains → return false.
//
//  Example trace for n = 27:
//    27 % 3 == 0  →  n = 9
//     9 % 3 == 0  →  n = 3
//     3 % 3 == 0  →  n = 1
//    n == 1  →  true ✓
//
//  Example trace for n = 10:
//    10 % 3 != 0  →  loop never runs
//    n == 10  →  false ✓
// ============================================================
public class Solution2
{
    public bool IsPowerOfThree(int n)
    {
        // write your solution here
        throw new NotImplementedException();
    }
}


// ============================================================
//  EASY 3 — DIGIT PRODUCT
//
//  Return the product of all NON-ZERO digits of an integer.
//  Zero digits are skipped because multiplying by 0 would make the result 0.
//
//  Examples:
//  Input:   234   Output: 24   →  2 × 3 × 4 = 24
//  Input:   105   Output:  5   →  1 × 5 = 5  (zero is skipped)
//  Input:   -36   Output: 18   →  3 × 6 = 18  (sign is ignored)
//  Input:     7   Output:  7   →  single digit, product is itself
//
//  How to think about it:
//  Step 1 — Remove the sign with Math.Abs().
//  Step 2 — Start with product = 1.
//  Step 3 — Extract the last digit with (num % 10).
//  Step 4 — If digit != 0, multiply it into product.
//  Step 5 — Chop with (num /= 10) and repeat until num is 0.
// ============================================================
public class Solution3
{
    public int DigitProduct(int num)
    {
        // write your solution here
        throw new NotImplementedException();
    }
}


// ============================================================
//  MEDIUM 1 — NEXT PERFECT SQUARE
//
//  Given integer n, return the smallest perfect square STRICTLY greater than n.
//  Perfect squares: 0, 1, 4, 9, 16, 25, 36, 49 …
//
//  Examples:
//  Input:   8   Output:  9   →  next after 8 is 3² = 9
//  Input:   9   Output: 16   →  9 itself is 3², but we want the NEXT one: 4² = 16
//  Input:   0   Output:  1   →  next after 0 is 1² = 1
//  Input:  25   Output: 36   →  next after 5² is 6² = 36
//
//  How to think about it:
//  Step 1 — Find the integer square root of n, i.e. floor(√n).
//           Do this with a while loop: keep incrementing root while
//           (root + 1)² <= n.  This avoids floating-point errors.
//  Step 2 — The answer is always (root + 1)².
//           This naturally handles the case where n is already a perfect
//           square, because we want the one AFTER it.
//
//  Example trace for n = 9:
//    root = 0 → (1)² = 1 <= 9 → root = 1
//    root = 1 → (2)² = 4 <= 9 → root = 2
//    root = 2 → (3)² = 9 <= 9 → root = 3
//    root = 3 → (4)² = 16 > 9 → stop
//    answer = (3 + 1)² = 16 ✓
//
//  Use long to avoid overflow on large inputs.
// ============================================================
public class Solution4
{
    public long NextPerfectSquare(long n)
    {
        // write your solution here
        throw new NotImplementedException();
    }
}


// ============================================================
//  MEDIUM 2 — HAPPY NUMBER
//
//  A number is "happy" if you repeatedly replace it with the
//  sum of squares of its digits and eventually reach 1.
//  If the sequence loops forever without hitting 1, it is "unhappy".
//
//  Examples:
//  Input: 19  Output: true
//    19 → 1²+9² = 82
//    82 → 8²+2² = 68
//    68 → 6²+8² = 100
//   100 → 1²+0²+0² = 1  → HAPPY ✓
//
//  Input:  4  Output: false
//    4 → 16 → 37 → 58 → 89 → 145 → 42 → 20 → 4  (cycle → UNHAPPY)
//
//  Input:  1  Output: true  (already 1)
//
//  How to think about it:
//  Step 1 — Write a helper method that computes the sum of squares of digits
//           (same digit-extraction loop as Easy 1 / Easy 3).
//  Step 2 — Create a HashSet<int> to remember every number you have visited.
//  Step 3 — Loop:
//           • If n == 1 → return true (happy).
//           • If seen contains n → cycle detected → return false (unhappy).
//           • Otherwise add n to seen, then replace n with the helper result.
// ============================================================
public class Solution5
{
    public bool IsHappy(int n)
    {
        // write your solution here
        throw new NotImplementedException();
    }
}


// ============================================================
//  HARD 1 — INTEGER SQUARE ROOT WITHOUT Math.Sqrt
//
//  Return the floor of √n using ONLY integer arithmetic.
//  Do NOT use Math.Sqrt, Math.Pow, or any floating-point trick.
//
//  Examples:
//  Input:   4   Output: 2   →  √4  = 2.0   → floor = 2
//  Input:   8   Output: 2   →  √8  = 2.82… → floor = 2
//  Input:   9   Output: 3   →  √9  = 3.0   → floor = 3
//  Input: 100   Output: 10
//  Input:   0   Output: 0
//  Input:   1   Output: 1
//
//  How to think about it (Binary Search):
//  Step 1 — Set lo = 0, hi = n.
//  Step 2 — Find mid = lo + (hi - lo) / 2.
//  Step 3 — Check: is mid² <= n AND (mid+1)² > n ?
//           YES → mid is the floor square root, return it.
//           NO, mid² < n  → answer is higher → lo = mid + 1.
//           NO, mid² > n  → answer is lower  → hi = mid - 1.
//  Step 4 — Repeat until found.
//
//  Important: use long for all variables to avoid overflow when squaring mid.
//
//  Example trace for n = 8:
//    lo=0, hi=8 → mid=4 → 4²=16 > 8 → hi=3
//    lo=0, hi=3 → mid=1 → 1²=1 < 8, 2²=4 < 8 → lo=2
//    lo=2, hi=3 → mid=2 → 2²=4 <= 8, 3²=9 > 8 → return 2 ✓
// ============================================================
public class Solution6
{
    public long IntSqrt(long n)
    {
        // write your solution here
        throw new NotImplementedException();
    }
}


// ============================================================
//  HARD 2 — LARGEST NUMBER BELOW N WITH DIGIT SUM S
//
//  Given integers n and s, find the largest integer STRICTLY less than n
//  whose digits add up to exactly s.  Return -1 if none exists.
//
//  Examples:
//  Input: n=100, s=9   Output: 90   →  9+0=9,  largest < 100
//  Input: n=50,  s=5   Output: 41   →  4+1=5,  larger than 32, 23, 14, 5
//  Input: n=30,  s=9   Output: 27   →  2+7=9
//  Input: n=10,  s=15  Output: -1   →  impossible with a single digit < 10
//  Input: n=1,   s=0   Output:  0   →  digit sum of 0 is 0
//
//  How to think about it:
//  Step 1 — Write a helper that computes the digit sum of a number
//           (same loop style as Easy 1 / Easy 3).
//  Step 2 — Start from candidate = n - 1 and count DOWN toward 0.
//  Step 3 — For each candidate, compute its digit sum.
//           If it equals s, return that candidate immediately
//           (it's the largest possible because we're going downward).
//  Step 4 — Special case: candidate == 0 and s == 0 → return 0.
//  Step 5 — If no match is found within 1,000,000 steps, return -1.
//
//  Hint: clamp your lower search bound with Math.Max(0, n - 1_000_000)
//        so you don't loop forever on large n.
// ============================================================
public class Solution7
{
    public int LargestBelowWithDigitSum(int n, int s)
    {
        // write your solution here
        throw new NotImplementedException();
    }
}


// ============================================================
//  DRIVER CODE — tests for all 7 problems
// ============================================================
class Program
{
    static void Main(string[] args)
    {
        // -------- EASY 1: COUNT EVEN DIGITS --------
        Solution1 s1 = new Solution1();
        Console.WriteLine("=== EASY 1: COUNT EVEN DIGITS ===");
        Console.WriteLine(s1.CountEvenDigits(1234));   // 2
        Console.WriteLine(s1.CountEvenDigits(9999));   // 0
        Console.WriteLine(s1.CountEvenDigits(2468));   // 4
        Console.WriteLine(s1.CountEvenDigits(-246));   // 3

        // -------- EASY 2: IS POWER OF THREE --------
        Solution2 s2 = new Solution2();
        Console.WriteLine("\n=== EASY 2: IS POWER OF THREE ===");
        Console.WriteLine(s2.IsPowerOfThree(1));     // True
        Console.WriteLine(s2.IsPowerOfThree(9));     // True
        Console.WriteLine(s2.IsPowerOfThree(27));    // True
        Console.WriteLine(s2.IsPowerOfThree(10));    // False
        Console.WriteLine(s2.IsPowerOfThree(0));     // False

        // -------- EASY 3: DIGIT PRODUCT --------
        Solution3 s3 = new Solution3();
        Console.WriteLine("\n=== EASY 3: DIGIT PRODUCT ===");
        Console.WriteLine(s3.DigitProduct(234));    // 24
        Console.WriteLine(s3.DigitProduct(105));    // 5
        Console.WriteLine(s3.DigitProduct(-36));    // 18
        Console.WriteLine(s3.DigitProduct(7));      // 7

        // -------- MEDIUM 1: NEXT PERFECT SQUARE --------
        Solution4 s4 = new Solution4();
        Console.WriteLine("\n=== MEDIUM 1: NEXT PERFECT SQUARE ===");
        Console.WriteLine(s4.NextPerfectSquare(8));    // 9
        Console.WriteLine(s4.NextPerfectSquare(9));    // 16
        Console.WriteLine(s4.NextPerfectSquare(0));    // 1
        Console.WriteLine(s4.NextPerfectSquare(25));   // 36

        // -------- MEDIUM 2: HAPPY NUMBER --------
        Solution5 s5 = new Solution5();
        Console.WriteLine("\n=== MEDIUM 2: HAPPY NUMBER ===");
        Console.WriteLine(s5.IsHappy(19));   // True
        Console.WriteLine(s5.IsHappy(4));    // False
        Console.WriteLine(s5.IsHappy(1));    // True
        Console.WriteLine(s5.IsHappy(7));    // True
        Console.WriteLine(s5.IsHappy(11));   // False

        // -------- HARD 1: INTEGER SQRT --------
        Solution6 s6 = new Solution6();
        Console.WriteLine("\n=== HARD 1: INTEGER SQRT ===");
        Console.WriteLine(s6.IntSqrt(4));     // 2
        Console.WriteLine(s6.IntSqrt(8));     // 2
        Console.WriteLine(s6.IntSqrt(9));     // 3
        Console.WriteLine(s6.IntSqrt(100));   // 10
        Console.WriteLine(s6.IntSqrt(0));     // 0
        Console.WriteLine(s6.IntSqrt(1));     // 1

        // -------- HARD 2: LARGEST BELOW WITH DIGIT SUM --------
        Solution7 s7 = new Solution7();
        Console.WriteLine("\n=== HARD 2: LARGEST BELOW WITH DIGIT SUM ===");
        Console.WriteLine(s7.LargestBelowWithDigitSum(100, 9));   // 90
        Console.WriteLine(s7.LargestBelowWithDigitSum(50,  5));   // 41
        Console.WriteLine(s7.LargestBelowWithDigitSum(30,  9));   // 27
        Console.WriteLine(s7.LargestBelowWithDigitSum(10, 15));   // -1
        Console.WriteLine(s7.LargestBelowWithDigitSum(1,   0));   // 0
    }
}
}