using System;

class MathFunctions
{
    static void Main()
    {
        // ============================================================
        // FULL NAME INPUT — Console.ReadLine() (same as getline in C++)
        // ============================================================

        // in C++  →  getline(cin, name);
        // in C#   →  Console.ReadLine()  already reads full line with spaces

        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine()!;
        Console.WriteLine("Your name is: " + fullName);   // Your name is: Rahul Kumar Sharma

        // Console.ReadLine() reads EVERYTHING until Enter is pressed
        // spaces, dots, anything — full line is captured



        // ============================================================
        // MATH FUNCTIONS — using Math class
        // ============================================================


        // -------------------------------------------------------
        // Math.Max() = returns the larger of two numbers
        // -------------------------------------------------------
        Console.WriteLine(Math.Max(10, 20));         // 20
        Console.WriteLine(Math.Max(99, 55));         // 99

        // -------------------------------------------------------
        // Math.Min() = returns the smaller of two numbers
        // -------------------------------------------------------
        Console.WriteLine(Math.Min(10, 20));         // 10
        Console.WriteLine(Math.Min(99, 55));         // 55

        // -------------------------------------------------------
        // Math.Pow() = x to the power y  (x^y)
        // -------------------------------------------------------
        Console.WriteLine(Math.Pow(2, 10));          // 1024  (2^10)
        Console.WriteLine(Math.Pow(5, 3));           // 125   (5^3)

        // -------------------------------------------------------
        // Math.Sqrt() = square root
        // -------------------------------------------------------
        Console.WriteLine(Math.Sqrt(144));           // 12
        Console.WriteLine(Math.Sqrt(2));             // 1.4142135623730951

        // -------------------------------------------------------
        // Math.Abs() = absolute value (removes minus sign)
        // -------------------------------------------------------
        Console.WriteLine(Math.Abs(-50));            // 50
        Console.WriteLine(Math.Abs(-3.14));          // 3.14

        // -------------------------------------------------------
        // Math.Round() = rounds to nearest whole number
        // -------------------------------------------------------
        Console.WriteLine(Math.Round(3.5));          // 4
        Console.WriteLine(Math.Round(7.2));          // 7

        // Math.Round() with decimal places
        Console.WriteLine(Math.Round(3.14159, 2));   // 3.14
        Console.WriteLine(Math.Round(9.9999, 3));    // 10

        // -------------------------------------------------------
        // Math.Ceiling() = always rounds UP  (ceil in C++)
        // -------------------------------------------------------
        Console.WriteLine(Math.Ceiling(4.1));        // 5
        Console.WriteLine(Math.Ceiling(7.9));        // 8

        // -------------------------------------------------------
        // Math.Floor() = always rounds DOWN
        // -------------------------------------------------------
        Console.WriteLine(Math.Floor(4.9));          // 4
        Console.WriteLine(Math.Floor(7.1));          // 7

        // -------------------------------------------------------
        // Math.Truncate() = cuts decimal part, no rounding at all
        // -------------------------------------------------------
        Console.WriteLine(Math.Truncate(9.99));      // 9
        Console.WriteLine(Math.Truncate(-3.7));      // -3  (not -4)

        // -------------------------------------------------------
        // Math.Log() = natural logarithm (base e)
        // -------------------------------------------------------
        Console.WriteLine(Math.Log(Math.E));         // 1
        Console.WriteLine(Math.Log(100));            // 4.605170185988092

        // Math.Log10() = log base 10
        Console.WriteLine(Math.Log10(1000));         // 3
        Console.WriteLine(Math.Log10(100));          // 2

        // -------------------------------------------------------
        // Math.Exp() = e raised to power x  (e^x)
        // -------------------------------------------------------
        Console.WriteLine(Math.Exp(1));              // 2.718281828  (e^1)
        Console.WriteLine(Math.Exp(2));              // 7.389056099  (e^2)

        // -------------------------------------------------------
        // Math.Sign() = returns -1, 0, or 1
        //               -1 if negative, 0 if zero, 1 if positive
        // -------------------------------------------------------
        Console.WriteLine(Math.Sign(-99));           // -1
        Console.WriteLine(Math.Sign(0));             // 0
        Console.WriteLine(Math.Sign(50));            // 1

        // -------------------------------------------------------
        // Math.PI = value of PI constant
        // Math.E  = value of e constant
        // -------------------------------------------------------
        Console.WriteLine(Math.PI);                  // 3.141592653589793
        Console.WriteLine(Math.E);                   // 2.718281828459045

        // -------------------------------------------------------
        // Math.Sin() / Math.Cos() / Math.Tan() = trigonometry
        // input is in RADIANS not degrees
        // -------------------------------------------------------
        Console.WriteLine(Math.Sin(Math.PI / 2));    // 1  (sin 90°)
        Console.WriteLine(Math.Cos(0));              // 1  (cos 0°)
        Console.WriteLine(Math.Tan(Math.PI / 4));    // 1  (tan 45°)

        // -------------------------------------------------------
        // Math.Clamp() = keeps value within a min-max range
        // -------------------------------------------------------
        Console.WriteLine(Math.Clamp(150, 0, 100));  // 100 (too high, clamped to max)
        Console.WriteLine(Math.Clamp(-5,  0, 100));  // 0   (too low,  clamped to min)
        Console.WriteLine(Math.Clamp(50,  0, 100));  // 50  (already in range)

        // -------------------------------------------------------
        // Math.DivRem() = division + remainder in one shot
        // -------------------------------------------------------
        int rem;
        int quot = Math.DivRem(17, 5, out rem);
        Console.WriteLine("Quotient: " + quot);      // Quotient: 3
        Console.WriteLine("Remainder: " + rem);      // Remainder: 2

        // -------------------------------------------------------
        // Random = generate random numbers (not Math class but imp)
        // -------------------------------------------------------
        Random rnd = new Random();
        Console.WriteLine(rnd.Next(1, 10));          // random int 1 to 9
        Console.WriteLine(rnd.NextDouble());         // random double 0.0 to 1.0
    }
}
