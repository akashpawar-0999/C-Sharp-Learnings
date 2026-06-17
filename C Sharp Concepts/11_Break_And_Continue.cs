using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BreakContinue
{
    static void Main ()
    {
        // ────────────────────────────────── FOR LOOP WITH BREAK AND CONTINUE ─────────────────────────────────────────

        // 1. stop loop when number reaches 5 (break)
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5) break;           // stops entire loop at 5
            Console.WriteLine(i);        // prints 1 2 3 4
        }

        // 2. skip even numbers, print only odd (continue)
        for (int j = 1; j <= 10; j++)
        {
            if (j % 2 == 0) continue;   // skips even, goes to next iteration
            Console.WriteLine(j);        // prints 1 3 5 7 9
        }

        // 3. find first number divisible by 7 between 1 to 100 (break)
        for (int k = 1; k <= 100; k++)
        {
            if (k % 7 == 0)
            {
                Console.WriteLine($"First divisible by 7: {k}");  // 7
                break;                   // no need to check further
            }
        }

        // 4. skip multiples of 3, print rest up to 15 (continue)
        for (int m = 1; m <= 15; m++)
        {
            if (m % 3 == 0) continue;   // skips 3 6 9 12 15
            Console.WriteLine(m);        // prints 1 2 4 5 7 8 10 11 13 14
        }

        // 5. sum numbers but stop if sum exceeds 50 (break)
        int runningSum = 0;
        for (int p = 1; p <= 100; p++)
        {
            runningSum += p;
            if (runningSum > 50)
            {
                Console.WriteLine($"Sum exceeded 50 at i={p}, sum={runningSum}");
                break;
            }
        }


        // ────────────────────────────────── WHILE LOOP WITH BREAK AND CONTINUE ──────────────────────────────────

        // 6. keep taking input until user types -1 (break)
        Console.Write("Enter number (-1 to quit): ");
        int userVal = int.Parse(Console.ReadLine()!);
        int whileSum = 0;
        while (true)                     // infinite loop — break controls exit
        {
            if (userVal == -1) break;    // exit condition
            whileSum += userVal;
            Console.Write("Enter number (-1 to quit): ");
            userVal = int.Parse(Console.ReadLine()!);
        }
        Console.WriteLine($"Total sum: {whileSum}");

        // 7. print numbers 1 to 20 but skip multiples of 4 (continue)
        int idx = 0;
        while (idx < 20)
        {
            idx++;
            if (idx % 4 == 0) continue; // skips 4 8 12 16 20
            Console.WriteLine(idx);
        }

        // 8. keep dividing number by 3 until less than 1, count steps (break)
        Console.Write("Enter number: ");
        double divVal = double.Parse(Console.ReadLine()!);
        int steps = 0;
        while (true)
        {
            if (divVal < 1)
            {
                Console.WriteLine($"Took {steps} steps to go below 1");
                break;
            }
            divVal /= 3;
            steps++;
        }
        
    }
}
