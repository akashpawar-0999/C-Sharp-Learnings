/*                  switch Statement in C#

Definition: Tests a single variable against multiple fixed values. 
Cleaner than a long if-else ladder when you're comparing one variable to many possible values.

-----------------------------------------------------------------------------------------------------------------
Key Points:

case must be a constant value — not a variable or expression
break exits the switch — without it, C# gives a compile error (unlike C++)
default runs if no case matches — optional but good practice
Two cases can share one block (fall-through by stacking labels)
C# switch works with int, char, string, enum, and more

------------------------------------------------- Syntax ---------------------------------------------------------
switch (variable)
{
    case value1:
        // code
        break;
    case value2:
        // code
        break;
    default:
        // code if no case matched
        break;
}
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SwitchCase
{
    static void Main ()
    {
        //---------------------------------- Example 1 — Days of the Week ----------------------------------

        Console.Write("Enter day number (1-7): ");
        int day = int.Parse(Console.ReadLine()!);

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day number. Enter 1 to 7.");
                break;
        }   


        //----------------------------------- Example 2 — Exam Grade --------------------------------------

        Console.Write("Enter your grade (A/B/C/D/F): ");
        char grade = char.Parse(Console.ReadLine()!);

        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent! Keep it up.");
                break;
            case 'B':
                Console.WriteLine("Good performance.");
                break;
            case 'C':
                Console.WriteLine("Average. Try harder.");
                break;
            case 'D':
                Console.WriteLine("Below average. Needs improvement.");
                break;
            case 'F':
                Console.WriteLine("Failed. Please study more.");
                break;
            default:
                Console.WriteLine("Invalid grade entered.");
                break;
        }

        //----------------------------------- Example 3 — Calculator --------------------------------------

        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine()!);

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine()!);

        Console.Write("Enter operator (+, -, *, /, %): ");
        string op = Console.ReadLine()!;

        double result;

        switch (op)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {result}");
                break;

            case "-":
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");
                break;

            case "*":
                result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result}");
                break;

            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result}");
                }
                break;

            case "%":
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Modulus by zero is not allowed.");
                }
                else
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {result}");
                }
                break;

            default:
                Console.WriteLine($"'{op}' is not a valid operator.");
                break;
        }
    }
}
