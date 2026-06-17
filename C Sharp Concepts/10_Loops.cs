using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Loops in C#

1. for loop
Runs a block of code a fixed number of times. You control start, condition, and increment in one line. Use when you know exactly how many times to loop.

2. while loop
Checks condition first, then runs the block. If condition is false at start, block never runs. Use when you don't know how many times to loop.

3. do-while loop
Runs the block first, then checks condition. Guaranteed to run at least once even if condition is false from the start.

4. foreach loop
Automatically iterates over every element in a collection or array one by one. No index needed. Cannot modify the collection while iterating.

*/

class LoopsTypes
{
    static void Main ()
    {

        // ──────────────────────────────────────────── for loop ────────────────────────────────────────────

        // 1. print 1 to 10
        for (int i = 1; i <= 10; i++)
            Console.WriteLine(i);


        // 2. print even numbers 1 to 20
        for (int i = 2; i <= 20; i += 2)
            Console.WriteLine(i);


        // 3. print in reverse 10 to 1
        for (int i = 10; i >= 1; i--)
            Console.WriteLine(i);


        // 4. sum of 1 to 100
        int total = 0;
        for (int i = 1; i <= 100; i++)
            total += i;
        Console.WriteLine($"Sum: {total}");          // Sum: 5050


        // 5. multiplication table of a number
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine()!);
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{num} x {i} = {num * i}");


        // 6. keep asking user until they enter 0
        for (;;)
        {
            Console.Write("Enter 0: ");
            string input1 = Console.ReadLine()!;
            if (input1 == "0")
                break;
            Console.WriteLine("You entered: " + input1);
        }
        Console.WriteLine ("You finally wrote 0 ") ;
        Console.WriteLine ("congratulations !!! ") ;


        // 7. find sum of digits of a number
        Console.Write("Enter a number : ");
        int m = int.Parse(Console.ReadLine()!);
        int SumOfDigits = 0;
        for (; m > 0; m = m / 10)
        {
            SumOfDigits += m % 10;
        }
        Console.WriteLine($"Digit sum: {SumOfDigits}");

    //public int Reverse(int x)
    
        // long y = x;
        // if (y < 0)
        // {
        //     y = Math.Abs(y);
        // } 
        // long reversed2 = 0;
        // for (; y > 0; y = y / 10)
        // {
        //     long digit2 = y % 10;
        //     reversed2 = reversed2 * 10 + digit2;
        // }
        // if (x < 0)
        // {
        //     reversed2 = -reversed2;
        // }
        // if (reversed2 > int.MaxValue || reversed2 < int.MinValue)
        // {
        // //    return 0;
        // }
        // return (int)reversed2;
    






        // ────────────────────────────────────────── while loop ──────────────────────────────────────────────

        // 1. print 1 to 10
        int count = 1;
        while (count <= 10)
        {
            Console.WriteLine(count);
            count++;
        }


        // 2. keep asking user until they enter 0
        Console.Write("Enter number (0 to stop): ");
        int input = int.Parse(Console.ReadLine()!);
        while (input != 0)
        {
            Console.WriteLine($"You entered: {input}");
            Console.Write("Enter number (0 to stop): ");
            input = int.Parse(Console.ReadLine()!);
        }


        // 3. find sum of digits of a number
        Console.Write("Enter number: ");
        int val = int.Parse(Console.ReadLine()!);
        int digitSum = 0;
        while (val > 0)
        {
            digitSum = digitSum + val % 10;   // extract last digit
            val /= 10;              // remove last digit
        }
        Console.WriteLine($"Digit sum: {digitSum}");


        // 4. count how many times a number is divisible by 2
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine()!);
        int divCount = 0;
        while (n % 2 == 0)
        {
            n /= 2;
            divCount++;
        }
        Console.WriteLine($"Divided by 2: {divCount} times");


        // 5. reverse a number
        Console.Write("Enter number: ");
        int original = int.Parse(Console.ReadLine()!);
        int reversed = 0;
        while (original > 0)
        {
            int digit = original % 10;   // extract last digit
            reversed = reversed * 10 + digit;  // build reversed number
            original /= 10;
        }
        Console.WriteLine($"Reversed: {reversed}");

    }
}
