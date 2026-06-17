using System;

namespace Functions
{
class Functions
{
    // ────────────────────── all functions defined here — INSIDE class, OUTSIDE Main ──────────────────────

    static void HappyBirthday1()
    {
        Console.WriteLine("Happy Birthday to You! 1 ");
    }

    static void festivalwish(string personName)
    {
        Console.WriteLine($"Happy DIWALI Dear {personName}!");
    }

    static string GetBirthdayMessage(string personName, int age)
    {
        return $"Happy Birthday {personName}! You are now {age} years old.";
    }


    // ────────────────────── Main — only calling functions here ────────────────────────────────────────

    static void Main(string[] args)
    {
        HappyBirthday1();

        festivalwish("Rahul");

        string msg = GetBirthdayMessage("akash", 21);
        Console.WriteLine(msg);
    }
}
}