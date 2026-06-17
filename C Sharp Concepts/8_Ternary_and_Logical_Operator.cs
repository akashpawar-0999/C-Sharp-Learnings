using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definition: Short form of if-else that returns a value. Works in a single line.
// Syntax: condition ? value_if_true : value_if_false


// Logical Operators ( && || ! ) :
// && — both sides must be true. If left is false, right side is NOT evaluated (short-circuit)
// || — at least one must be true. If left is true, right side is NOT evaluated (short-circuit)
// ! — flips true to false and false to true

class TernaryLogical
{
    static void Main ()
    {
        int age = 17;
        string status = (age >= 18) ? "Adult" : "Minor";
        Console.WriteLine(status); // Minor

        int a = 10, b = 20;
        int max = (a > b) ? a : b;
        Console.WriteLine(max); // 20

        int marks = 45;
        string result = (marks >= 50) ? "Pass" : "Fail";
        Console.WriteLine(result); // Fail

        // inside Console.WriteLine directly
        int num = -5;
        Console.WriteLine((num > 0) ? "Positive" : "Not Positive"); // Not Positive

        // nested ternary — only when simple, max 1 level
        int n = 0;
        string sign = (n > 0) ? "Positive" : (n < 0) ? "Negative" : "Zero";
        Console.WriteLine(sign); // Zero

    }
}