using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DataTypes
{
    static void Main()
    {
        // byte = unsigned 8-bit integer, range 0 to 255
        byte b = 255;
        Console.WriteLine(b);                        // 255

        // sbyte = signed 8-bit integer, range -128 to 127
        sbyte sb = -100;
        Console.WriteLine(sb);                       // -100

        // short = signed 16-bit integer, range -32768 to 32767
        short s = 32000;
        Console.WriteLine(s);                        // 32000
        
        // ushort = unsigned 16-bit integer, range 0 to 65535
        ushort us = 65000;
        Console.WriteLine(us);                       // 65000

        // int = signed 32-bit integer, most commonly used whole number type
        int i = 100000;
        Console.WriteLine(i);                        // 100000

        // uint = unsigned 32-bit integer, range 0 to 4294967295
        uint ui = 4000000000;
        Console.WriteLine(ui);                       // 4000000000

        // long = signed 64-bit integer, for very large whole numbers
        long l = 9000000000000L;
        Console.WriteLine(l);                        // 9000000000000

        // ulong = unsigned 64-bit integer, largest whole number type
        ulong ul = 18000000000000000000UL;
        Console.WriteLine(ul);                       // 18000000000000000000

        // float = 32-bit decimal, less precise, needs F suffix
        float f = 3.14F;
        Console.WriteLine(f);                        // 3.14

        // double = 64-bit decimal, default decimal type, more precise
        double d = 3.141592653589793;
        Console.WriteLine(d);                        // 3.141592653589793

        // decimal = 128-bit high precision decimal, needs M suffix, use for money
        decimal dec = 99.99M;
        Console.WriteLine(dec);                      // 99.99

        // char = single character, written in single quotes
        char c = 'A';
        Console.WriteLine(c);                        // A

        // string = sequence of characters, written in double quotes
        string str = "Hello, World!";
        Console.WriteLine(str);                      // Hello, World!

        // bool = stores only true or false
        bool isOn = true;
        Console.WriteLine(isOn);                     // True

        // object = base type of all types, can hold any value
        object obj = 42;
        Console.WriteLine(obj);                      // 42

        // dynamic = type is decided at runtime, not at compile time
        dynamic dyn = "I can change type!";
        Console.WriteLine(dyn);                      // I can change type!

        // var = compiler auto-detects the type from the assigned value
        var v = 100;
        Console.WriteLine(v.GetType());              // System.Int32

        // int? = nullable int, can hold a number or null
        int? nullableInt = null;
        Console.WriteLine(nullableInt == null);      // True

        // string? = nullable string, can hold text or null (C# 8.0+)
        string? nullableStr = null;
        Console.WriteLine(nullableStr ?? "was null"); // was null
    }
}
