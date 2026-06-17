using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IfElse
{
    static void Main()
    {
        //---------------------------------------------------------------------------------------------------------------------

        // if (condition)
        // {
        //     // runs if condition is true
        // }
        // else
        // {
        //     // runs if condition is false
        // }


        //--------------------------------------------- Basic if-else ---------------------------------------------------------

        int age = 20;

        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a minor.");
        }


        //------------------------------------- if - else if - else ladder ---------------------------------------------------

        int marks = 75;

        if (marks >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 75)
        {
            Console.WriteLine("Grade: B");   // this runs
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade: C");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }

        // Important: Only ONE block runs — the first condition that is true. 
        // Even if multiple conditions would be true, C# stops at the first match.


        //------------------------------ Without else — just checking a condition --------------------------------------------

        int x = 10;

        if (x > 0)
        {
            Console.WriteLine("x is positive");
        }

        // program continues here regardless
        Console.WriteLine("Done");


        //------------------------------ Single-line if (no braces) — valid but risky ----------------------------------------

        int n = 5;

        if (n > 0)
            Console.WriteLine("Positive");   // only THIS line is inside if
            Console.WriteLine("Always runs"); // this is NOT inside if — misleading!


        //--------------------------------------------------------------------------------------------------------------------

        // Nested if-else — grade + pass/fail system
        int marks1 = 72;
        bool attended = true;

        if (attended)
        {
            if (marks1 >= 90)
            {
                Console.WriteLine("A grade — Excellent");
            }
            else if (marks1 >= 75)
            {
                Console.WriteLine("B grade — Good");
            }
            else if (marks1 >= 50)
            {
                Console.WriteLine("C grade — Pass");   // this runs
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        else
        {
            Console.WriteLine("Detained — attendance shortage");
        }













    }
}