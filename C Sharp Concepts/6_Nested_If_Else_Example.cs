using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class nestedIfElse
{
    static void Main ()
    {
        
        // Full real example — login check with nested if
        string username = "admin";
        string password = "1234";

        Console.Write("Enter username: ");
        string inputUser = Console.ReadLine()!;

        Console.Write("Enter password: ");
        string inputPass = Console.ReadLine()!;

        if (inputUser == username)
        {
            if (inputPass == password)
            {
                Console.WriteLine("Login successful. Welcome!");
            }
            else
            {
                Console.WriteLine("Wrong password.");
            }
        }
        else
        {
            Console.WriteLine("Username not found.");
        }


        //-----------------------------------------------------------------------------------------------------------

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