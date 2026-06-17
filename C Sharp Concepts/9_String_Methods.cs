using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringMethod
{
    static void Main ()
    {
        // ────────────────────────────────────── 1. LENGTH & CHECKING ──────────────────────────────────────────────
        string city = "Hello World";
        Console.WriteLine(city.Length);                          // 11

        Console.WriteLine(string.IsNullOrEmpty(""));             // True
        Console.WriteLine(string.IsNullOrEmpty(null));           // True
        Console.WriteLine(string.IsNullOrEmpty("Hi"));           // False
        Console.WriteLine(string.IsNullOrWhiteSpace("   "));     // True


        // ─────────────────────────────────── 2. ACCESSING CHARACTERS ──────────────────────────────────────────────

        string word = "Hello";
        Console.WriteLine(word[0]);                              // H
        Console.WriteLine(word[4]);                              // o

        for (int i = 0; i < word.Length; i++)
            Console.Write(word[i] + " ");                        // H e l l o
        Console.WriteLine();


        // ────────────────────────────────────────────── 3. SEARCHING ──────────────────────────────────────────────

        string sentence = "Hello World";
        Console.WriteLine(sentence.IndexOf("World"));            // 6
        Console.WriteLine(sentence.IndexOf("xyz"));              // -1
        Console.WriteLine(sentence.IndexOf('o'));                // 4
        Console.WriteLine(sentence.LastIndexOf('o'));            // 7
        Console.WriteLine(sentence.Contains("World"));           // True
        Console.WriteLine(sentence.Contains("xyz"));             // False
        Console.WriteLine(sentence.StartsWith("Hello"));         // True
        Console.WriteLine(sentence.EndsWith("World"));           // True


        // ────────────────────────────────────────────── 4. MODIFYING / TRANSFORMING ────────────────────────────────

        string padded = "  Hello World  ";
        Console.WriteLine(padded.Trim());                        // "Hello World"
        Console.WriteLine(padded.TrimStart());                   // "Hello World  "
        Console.WriteLine(padded.TrimEnd());                     // "  Hello World"
        Console.WriteLine(padded.ToUpper());                     // "  HELLO WORLD  "
        Console.WriteLine(padded.ToLower());                     // "  hello world  "

        string line = "I like cats. Cats are nice.";
        Console.WriteLine(line.Replace("cats", "dogs"));         // "I like dogs. Cats are nice."
        // case-sensitive — 'Cats' not replaced

        string phrase = "Hello World";
        Console.WriteLine(phrase.Remove(5));                     // "Hello"     — removes index 5 to end
        Console.WriteLine(phrase.Remove(5, 1));                  // "HelloWorld" — removes 1 char at index 5


        // ────────────────────────────────────────────── 5. SUBSTRING ─────────────────────────────────────────────────

        string msg = "Hello World";
        Console.WriteLine(msg.Substring(6));                     // "World"
        Console.WriteLine(msg.Substring(0, 5));                  // "Hello"
        Console.WriteLine(msg.Substring(6, 3));                  // "Wor"


        // ──────────────────────────────────────────── 6. SPLIT AND JOIN ────────────────────────────────────────────

        string data = "apple,banana,mango,grape";
        string[] fruits = data.Split(',');

        foreach (string fruit in fruits)
            Console.WriteLine(fruit);                            // apple banana mango grape

        Console.WriteLine(fruits.Length);                        // 4

        string joined = string.Join(" - ", fruits);
        Console.WriteLine(joined);                               // apple - banana - mango - grape


        // ──────────────────────────────────────────── 7. INTERPOLATION AND CONCATENATION ──────────────────────────────

        string userName = "Rahul";
        int userAge = 20;

        Console.WriteLine("Name: " + userName + ", Age: " + userAge);       // concatenation
        Console.WriteLine($"Name: {userName}, Age: {userAge}");             // interpolation — preferred
        Console.WriteLine($"Next year: {userAge + 1}");                     // expression inside
        Console.WriteLine($"Name length: {userName.Length}");


        // ──────────────────────────────────────────── 8. COMPARE STRINGS ──────────────────────────────────────────────

        string str1 = "hello";
        string str2 = "HELLO";

        Console.WriteLine(str1 == str2);                                          // False — case-sensitive
        Console.WriteLine(str1.Equals(str2, StringComparison.OrdinalIgnoreCase)); // True  — ignore case
        Console.WriteLine(string.Compare(str1, str2));                            // non-zero — not equal


        // ──────────────────────────────────────────── 9. CLEAR EQUIVALENT & STRINGBUILDER ─────────────────────────────

        string text = "Hello";
        text = "";                                               // C++ .clear() equivalent
        Console.WriteLine(text.Length);                          // 0

        // StringBuilder — use when building strings in loops (fast, modifies in place)
        StringBuilder sb = new StringBuilder();
        sb.Append("Hello");
        sb.Append(" ");
        sb.Append("World");
        sb.AppendLine("!");                                      // adds text + newline
        sb.Insert(5, ",");                                       // insert at index 5
        sb.Replace("World", "C#");

        Console.WriteLine(sb.ToString());                        // "Hello, C#!"
        sb.Clear();                                              // actual in-place clear
        Console.WriteLine(sb.Length);                            // 0
    
    }
}
