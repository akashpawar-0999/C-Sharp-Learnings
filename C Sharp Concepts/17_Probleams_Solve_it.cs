using System;
using System.Collections.Generic;

namespace CSharpConcepts
{
    // ============================================================
    //  EASY 1 — COUNT EVEN DIGITS
    // ============================================================
    public class Solution1
    {
        public int CountEvenDigits(int num)
        {
            num = Math.Abs(num);
            int count = 0;
            if (num == 0) return 1; // 0 is an even digit
            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 == 0) count++;
                num /= 10;
            }
            return count;
        }
    }

    // ============================================================
    //  EASY 2 — IS POWER OF 3
    // ============================================================
    public class Solution2
    {
        public bool IsPowerOfThree(int n)
        {
            if (n <= 0) return false;
            while (n % 3 == 0)
                n /= 3;
            return n == 1;
        }
    }

    // ============================================================
    //  EASY 3 — DIGIT PRODUCT
    // ============================================================
    public class Solution3
    {
        public int DigitProduct(int num)
        {
            num = Math.Abs(num);
            int product = 1;
            while (num > 0)
            {
                int digit = num % 10;
                if (digit != 0) product *= digit;
                num /= 10;
            }
            return product;
        }
    }

    // ============================================================
    //  MEDIUM 1 — NEXT PERFECT SQUARE
    // ============================================================
    public class Solution4
    {
        public long NextPerfectSquare(long n)
        {
            long root = 0;
            while ((root + 1) * (root + 1) <= n)
                root++;
            // root is now floor(sqrt(n)), so next perfect square is (root+1)^2
            return (root + 1) * (root + 1);
        }
    }

    // ============================================================
    //  MEDIUM 2 — HAPPY NUMBER
    // ============================================================
    public class Solution5
    {
        private int SumOfSquares(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            return sum;
        }

        public bool IsHappy(int n)
        {
            HashSet<int> seen = new HashSet<int>();
            while (n != 1)
            {
                if (seen.Contains(n)) return false;
                seen.Add(n);
                n = SumOfSquares(n);
            }
            return true;
        }
    }

    // ============================================================
    //  HARD 1 — INTEGER SQUARE ROOT WITHOUT Math.Sqrt
    // ============================================================
    public class Solution6
    {
        public long IntSqrt(long n)
        {
            if (n == 0) return 0;
            long lo = 0, hi = n;
            while (lo <= hi)
            {
                long mid = lo + (hi - lo) / 2;
                if (mid * mid <= n && (mid + 1) * (mid + 1) > n)
                    return mid;
                else if (mid * mid < n)
                    lo = mid + 1;
                else
                    hi = mid - 1;
            }
            return lo;
        }
    }

    // ============================================================
    //  HARD 2 — LARGEST NUMBER BELOW N WITH DIGIT SUM S
    // ============================================================
    public class Solution7
    {
        private int DigitSum(int num)
        {
            num = Math.Abs(num);
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        public int LargestBelowWithDigitSum(int n, int s)
        {
            int limit = Math.Max(0, n - 1_000_000);
            for (int candidate = n - 1; candidate >= limit; candidate--)
            {
                if (candidate == 0 && s == 0) return 0;
                if (candidate > 0 && DigitSum(candidate) == s) return candidate;
            }
            return -1;
        }
    }

    // ============================================================
    //  DRIVER CODE
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