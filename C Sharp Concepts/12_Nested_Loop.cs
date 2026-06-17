using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoop
{
    class NestedLoop
    {
    static void Main ()
    {

        Console.WriteLine("-----------------------------------------------------------------------------");

        // 1. EMPTY RECTANGLE (rows=5, cols=10)

        Console.Write("Enter rows of triangle : ");
        int rows = int.Parse(Console.ReadLine()!);

        Console.Write("Enter Columns of triangle : ");
        int cols = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= cols; j++)
            {
                // print * only on border — first/last row or first/last column
                if (i == 1 || i == rows || j == 1 || j == cols)
                    Console.Write("* ");
                else
                    Console.Write("  ");    // empty inside
            }
            Console.WriteLine();
        }

        // output:
        
        // * * * * * * * * * *
        // *                 *
        // *                 *
        // *                 *
        // * * * * * * * * * *


        Console.WriteLine("-----------------------------------------------------------------------------");

        // 2. EMPTY RIGHT ANGLED TRIANGLE (rows=6)
        
        Console.Write("Enter rows of triangle : ");
        int triRows = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= triRows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                // first column — always print
                // last row — always print
                // last column of that row (j == i) — always print
                if (j == 1 || i == triRows || j == i)
                    Console.Write("* ");
                else
                    Console.Write("  ");    // empty inside
            }
            Console.WriteLine();
        }

        // output:

        // *
        // * *
        // *   *
        // *     *
        // *       *
        // * * * * * * 
        Console.WriteLine("-----------------------------------------------------------------------------");

        Console.Write("Enter lenth of triangle : ");
        int length = int.Parse(Console.ReadLine()!);
        Console.Write("Enter breadth of triangle : ");
        int breadth = int.Parse(Console.ReadLine()!);

        for (int i = 0 ; i < length ; i++ )
            {
                for (int j = 0 ; j < breadth ; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }

        // Output :

        // * * * * * * 
        // * * * * * * 
        // * * * * * * 
        // * * * * * * 
        // * * * * * * 

        Console.WriteLine("-----------------------------------------------------------------------------");
        
        Console.Write("Enter height of triangle : ");
        int height = int.Parse(Console.ReadLine()!);

        for (int i = 0 ; i < height ; i++ )
            {
                for (int j = 1 ; j < height - i + 1 ; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("");
            }


        // Output :

        // * * * * *
        // * * * *
        // * * *
        // * *
        // *

        Console.WriteLine("-----------------------------------------------------------------------------");


        
        Console.Write("Enter height2 of triangle : ");
        int height2 = int.Parse(Console.ReadLine()!);

        for (int i = 0 ; i < height2 ; i++ )
            {
                for (int j = 0 ; j <= i ; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("");
            }

        // *
        // * *
        // * * *
        // * * * *
        // * * * * *
        // * * * * * *
        
    }
    }

}