using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InputOutput
{
    static void Main()
    {
        // int input output
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine()!); 
        // int.Parse()"25" → 25
        Console.WriteLine("Your age is " + age);                        // Your age is 21
        
        /* -------------- USE OF CONSOLE AND READLINE AND PARSE --------------
        1. Console.Write        →  prints "Enter your age: " on screen
        2. Console.ReadLine()   →  waits, user types 21, returns "21" (string)
        3. int.Parse("21")      →  converts "21" → 21 (int)
        4. int age = 21         →  stores 21 in age variable
        ---------------------------------------------------------------------- */

        // double input output
        Console.Write("Enter your marks: ");
        double marks = double.Parse(Console.ReadLine()!);
        // double.Parse()"3.14" → 3.14
        Console.WriteLine("You scored " + marks + " marks");            // You scored 85.5 marks

        // float input output
        Console.Write("Enter temperature: ");
        float temp = float.Parse(Console.ReadLine()!);
        // float.Parse()"36.6" → 36.6F
        Console.WriteLine("Temperature is " + temp + " degrees");       // Temperature is 36.6 degrees

        // string input output
        Console.Write("Enter your name: ");
        string name = Console.ReadLine()!;
        // string is already text, ReadLine gives text, no conversion needed
        Console.WriteLine("Hello, " + name + "!");                      // Hello, Rahul!

        // char input output
        Console.Write("Enter a grade (A/B/C): ");
        char grade = char.Parse(Console.ReadLine()!);
        // char.Parse()"A" → 'A'
        Console.WriteLine("Your grade is " + grade);                    // Your grade is A

        // bool input output
        Console.Write("Are you a student? (true/false): ");
        bool isStudent = bool.Parse(Console.ReadLine()!);
        // bool.Parse()"true" → true
        Console.WriteLine("Student status: " + isStudent);             // Student status: True

        // long input output
        Console.Write("Enter phone number: ");
        long phone = long.Parse(Console.ReadLine()!);
        Console.WriteLine("Phone: " + phone);                           // Phone: 9876543210

        // decimal input output
        Console.Write("Enter product price: ");
        decimal price = decimal.Parse(Console.ReadLine()!);
        Console.WriteLine("Price is Rs." + price);                      // Price is Rs.499.99

        // two int inputs with concatenation
        Console.Write("Enter first number: ");
        int n1 = int.Parse(Console.ReadLine()!);
        Console.Write("Enter second number: ");
        int n2 = int.Parse(Console.ReadLine()!);
        Console.WriteLine(n1 + " + " + n2 + " = " + (n1 + n2));       // 10 + 20 = 30

        // string and int together
        Console.Write("Enter item name: ");
        string item = Console.ReadLine()!;
        Console.Write("Enter quantity: ");
        int qty = int.Parse(Console.ReadLine()!);
        Console.WriteLine("You ordered " + qty + " " + item);          // You ordered 3 Apples

        // string and double together
        Console.Write("Enter student name: ");
        string sname = Console.ReadLine()!;
        Console.Write("Enter percentage: ");
        double percent = double.Parse(Console.ReadLine()!);
        Console.WriteLine(sname + " scored " + percent + "%");         // Priya scored 92.5%

        // using Convert instead of Parse
        Console.Write("Enter your salary: ");
        int salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Monthly salary is Rs." + salary);           // Monthly salary is Rs.50000
    }
}
