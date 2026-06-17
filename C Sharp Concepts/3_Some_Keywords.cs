using System;                        // using = import a library/namespace


// ============================================================
// ALL C# KEYWORDS
// ============================================================

// abstract    as          base        bool        break
// byte        case        catch       char        checked
// class       const       continue    decimal     default
// delegate    do          double      else        enum
// event       explicit    extern      false       finally
// fixed       float       for         foreach     goto
// if          implicit    in          int         interface
// internal    is          lock        long        namespace
// new         null        object      operator    out
// override    params      private     protected   public
// readonly    ref         return      sbyte       sealed
// short       sizeof      stackalloc  static      string
// struct      switch      this        throw       true
// try         typeof      uint        ulong       unchecked
// unsafe      ushort      using       virtual     void
// volatile    while       var         dynamic     yield



// ============================================================
// IMPORTANT KEYWORDS — MEANING AND USE
// ============================================================

namespace MyProgram                  // namespace = a container that groups related code
{                                    // like a folder name for your code

    class MyProgram                    // class = blueprint to create objects
    {
        // -------------------------------------------------------
        // const = constant, value can NEVER be changed after set
        // -------------------------------------------------------
        const double PI = 3.14159;
        const int MAXLIMIT = 100;

        // -------------------------------------------------------
        // static = belongs to class itself, not to any object
        //          Main() must be static so C# can run it directly
        // -------------------------------------------------------
        static void Main()
        {
            // -------------------------------------------------------
            // var = compiler decides the type automatically
            // -------------------------------------------------------
            var name = "Rahul";           // becomes string
            var age  = 21;               // becomes int
            Console.WriteLine(name + " " + age);    // Rahul 21

            // -------------------------------------------------------
            // const inside method
            // -------------------------------------------------------
            const int DAYS = 7;
            Console.WriteLine("Days in a week: " + DAYS);   // 7
            // DAYS = 10;  // ❌ ERROR — cannot change const

            // -------------------------------------------------------
            // new = creates a new object/instance
            // -------------------------------------------------------
            Random rand = new Random();
            int num = rand.Next(1, 100);
            Console.WriteLine("Random number: " + num);

            // -------------------------------------------------------
            // if / else = condition checking
            // -------------------------------------------------------
            int marks = 75;
            if (marks >= 60)
            {
                Console.WriteLine("Pass");          // Pass
            }
            else
            {
                Console.WriteLine("Fail");
            }

            // -------------------------------------------------------
            // switch = multiple condition checking (cleaner than if-else)
            // -------------------------------------------------------
            int day = 2;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");   // Tuesday
                    break;
                default:
                    Console.WriteLine("Other day");
                    break;
            }

            // -------------------------------------------------------
            // for = loop when you know how many times to repeat
            // -------------------------------------------------------
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Count: " + i);   // 1, 2, 3
            }

            // -------------------------------------------------------
            // while = loop when you don't know how many times
            // -------------------------------------------------------
            int x = 1;
            while (x <= 3)
            {
                Console.WriteLine("While: " + x);   // 1, 2, 3
                x++;
            }

            // -------------------------------------------------------
            // do while = runs at least once, then checks condition
            // -------------------------------------------------------
            int y = 1;
            do
            {
                Console.WriteLine("Do: " + y);      // 1, 2, 3
                y++;
            } while (y <= 3);

            // -------------------------------------------------------
            // foreach = loop through each item in a collection
            // -------------------------------------------------------
            string[] fruits = { "Apple", "Mango", "Banana" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);           // Apple Mango Banana
            }

            // -------------------------------------------------------
            // break = exit the loop immediately
            // -------------------------------------------------------
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3) break;
                Console.WriteLine(i);               // 1, 2
            }

            // -------------------------------------------------------
            // continue = skip current iteration, go to next
            // -------------------------------------------------------
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3) continue;
                Console.WriteLine(i);               // 1, 2, 4, 5
            }

            // -------------------------------------------------------
            // return = exit a method and optionally send back a value
            // -------------------------------------------------------
            int result = Add(10, 20);
            Console.WriteLine("Sum: " + result);    // Sum: 30

            // -------------------------------------------------------
            // try / catch = handle errors so program doesnt crash
            // -------------------------------------------------------
            try
            {
                int a = int.Parse("abc");           // ❌ this will fail
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);  // Error: Input string was not in a correct format.
            }

            // -------------------------------------------------------
            // null = empty, nothing, no value assigned
            // -------------------------------------------------------
            string? city = null;
            Console.WriteLine(city == null);        // True

            // -------------------------------------------------------
            // is = checks what type a variable is
            // -------------------------------------------------------
            object obj = "Hello";
            Console.WriteLine(obj is string);       // True

            // -------------------------------------------------------
            // as = tries to convert, returns null if fails (no crash)
            // -------------------------------------------------------
            object val = "World";
            string? str = val as string;
            Console.WriteLine(str);                 // World 

            // -------------------------------------------------------
            // typeof = gives the type information of a type
            // -------------------------------------------------------
            Console.WriteLine(typeof(int));         // System.Int32
            Console.WriteLine(typeof(string));      // System.String

            // -------------------------------------------------------
            // sizeof = gives memory size in bytes
            // -------------------------------------------------------
            Console.WriteLine(sizeof(int));         // 4
            Console.WriteLine(sizeof(double));      // 8
            Console.WriteLine(sizeof(char));        // 2

            // -------------------------------------------------------
            // readonly = value set once (in constructor), never again
            // -------------------------------------------------------
            // (see class example at bottom)

            // -------------------------------------------------------
            // void = method returns nothing
            // -------------------------------------------------------
            PrintHello();                           // Hello!

            // -------------------------------------------------------
            // params = pass any number of arguments to a method
            // -------------------------------------------------------
            Console.WriteLine(Sum(1, 2, 3, 4, 5)); // 15

            // -------------------------------------------------------
            // out = method returns extra values through parameters
            // -------------------------------------------------------
            int quotient, remainder;
            Divide(10, 3, out quotient, out remainder);
            Console.WriteLine(quotient + " rem " + remainder);  // 3 rem 1

            // -------------------------------------------------------
            // ref = pass variable by reference (method can change it)
            // -------------------------------------------------------
            int number = 5;
            Double(ref number);
            Console.WriteLine(number);             // 10

            // -------------------------------------------------------
            // using (another use) = auto closes resource after use
            // -------------------------------------------------------
            // using (var file = new System.IO.StreamWriter("test.txt"))
            // {
            //     file.WriteLine("Hello");
            // }  // file automatically closed here



            // ============================================================
            // TYPE CONVERSION
            // ============================================================

            // -------------------------------------------------------
            // 1. IMPLICIT conversion = automatic, no data loss, safe
            // -------------------------------------------------------
            int   intVal    = 100;
            long  longVal   = intVal;       // int → long (automatic)
            float floatVal  = intVal;       // int → float (automatic)
            double doubleVal = floatVal;    // float → double (automatic)

            Console.WriteLine(longVal);     // 100
            Console.WriteLine(floatVal);    // 100
            Console.WriteLine(doubleVal);   // 100

            // -------------------------------------------------------
            // 2. EXPLICIT conversion (casting) = manual, may lose data
            //    use when converting bigger type → smaller type
            // -------------------------------------------------------
            double d  = 9.99;
            int    i2 = (int)d;             // decimal part is LOST
            Console.WriteLine(i2);          // 9  ← not 10, just cuts off

            long   bigNum  = 123456789;
            int    smallNum = (int)bigNum;  // manually cast
            Console.WriteLine(smallNum);    // 123456789

            float  f2 = 3.14F;
            int    i3 = (int)f2;            // 3 (decimal lost)
            Console.WriteLine(i3);          // 3

            // -------------------------------------------------------
            // 3. Convert class = converts any type to any type
            // -------------------------------------------------------
            string numStr = "42";
            int    fromStr   = Convert.ToInt32(numStr);    // string → int
            double fromStr2  = Convert.ToDouble("3.14");   // string → double
            string fromInt   = Convert.ToString(100);      // int → string
            bool   fromBool  = Convert.ToBoolean(1);       // 1 → true, 0 → false
            int    fromBool2 = Convert.ToInt32(true);      // true → 1

            Console.WriteLine(fromStr);     // 42
            Console.WriteLine(fromStr2);    // 3.14
            Console.WriteLine(fromInt);     // 100
            Console.WriteLine(fromBool);    // True
            Console.WriteLine(fromBool2);   // 1

            // -------------------------------------------------------
            // 4. Parse = string → specific type (crashes if invalid)
            // -------------------------------------------------------
            int    p1 = int.Parse("99");
            double p2 = double.Parse("3.14");
            bool   p3 = bool.Parse("true");
            Console.WriteLine(p1 + " " + p2 + " " + p3);  // 99 3.14 True

            // -------------------------------------------------------
            // 5. TryParse = safe Parse, returns true/false, no crash
            // -------------------------------------------------------
            bool success = int.TryParse("abc", out int parsed);
            Console.WriteLine(success);     // False  (invalid input)
            Console.WriteLine(parsed);      // 0      (default value)

            bool success2 = int.TryParse("55", out int parsed2);
            Console.WriteLine(success2);    // True
            Console.WriteLine(parsed2);     // 55

            // -------------------------------------------------------
            // 6. ToString = any type → string
            // -------------------------------------------------------
            int    n   = 500;
            double d2  = 3.14;
            bool   b2  = true;
            string s1  = n.ToString();
            string s2  = d2.ToString();
            string s3  = b2.ToString();
            Console.WriteLine(s1 + " " + s2 + " " + s3);  // 500 3.14 True
        }


        // -------------------------------------------------------
        // void method = does something, returns nothing
        // -------------------------------------------------------
        static void PrintHello()
        {
            Console.WriteLine("Hello!");
        }

        // -------------------------------------------------------
        // return method = does something and sends back a value
        // -------------------------------------------------------
        static int Add(int a, int b)
        {
            return a + b;               // sends back the sum
        }

        // -------------------------------------------------------
        // params = accept any number of values
        // -------------------------------------------------------
        static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (int n in numbers)
                total += n;
            return total;
        }

        // -------------------------------------------------------
        // out = method gives back extra values
        // -------------------------------------------------------
        static void Divide(int a, int b, out int q, out int r)
        {
            q = a / b;
            r = a % b;
        }

        // -------------------------------------------------------
        // ref = method can change the original variable
        // -------------------------------------------------------
        static void Double(ref int n)
        {
            n = n * 2;
        }
    }


    // -------------------------------------------------------
    // readonly example inside a class
    // readonly = set once in constructor, never changed again
    // -------------------------------------------------------
    class Student
    {
        readonly int rollNumber;        // can only be set in constructor

        public Student(int roll)
        {
            rollNumber = roll;          // set here
        }

        public void Show()
        {
            Console.WriteLine("Roll: " + rollNumber);
            // rollNumber = 99;  // ❌ ERROR — cannot change readonly
        }
    }
}
