using System;

class CSharpArrays
{
    // Arrays are REFERENCE TYPES in C#.
    // When you pass an array to a method, you're passing the reference (address),
    // NOT a copy — so changes inside the method affect the original array.
    static void DoubleAll(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i] *= 2;
    }

    // A method CAN return an array just like any other type.
    // Here we build and return a new array of squares: 1^2, 2^2, ... n^2
    static int[] GetSquares(int n)
    {
        int[] result = new int[n];
        for (int i = 0; i < n; i++)
            result[i] = (i + 1) * (i + 1);
        return result;
    }

    // `params` lets the caller pass any number of arguments without creating an array manually.
    // C# bundles them into an int[] behind the scenes.
    static int SumAll(params int[] values)
    {
        int total = 0;
        foreach (int v in values)
            total += v;
        return total;
    }

    // Reusable print helper — prints every element on one line with an optional label.
    static void PrintArray(int[] arr, string label = "")
    {
        if (label != "") Console.Write(label + ": ");
        foreach (int x in arr)
            Console.Write(x + " ");
        Console.WriteLine();
    }

    static void Main()
    {
        // ====================================================
        // CONCEPT 1 — DECLARATION & INITIALIZATION
        // Three styles, all equivalent for int[]:
        //   Style A: allocate first, then assign values one by one
        //   Style B: allocate + initialise in one step with { }
        //   Style C: shorthand — compiler infers the size from { }
        // ====================================================
        Console.WriteLine("=== 1. DECLARATION & INITIALIZATION ===");

        // Style A
        int[] arr1 = new int[5];
        arr1[0] = 10; arr1[1] = 20; arr1[2] = 30; arr1[3] = 40; arr1[4] = 50;

        // Style B
        int[] arr2 = new int[] { 10, 20, 30, 40, 50 };

        // Style C (most common in practice)
        int[] arr3 = { 10, 20, 30, 40, 50 };

        // Arrays work for any type
        string[] names  = { "Akash", "Rohan", "Sarvesh" };
        double[] prices = { 9.99, 49.5, 199.0 };
        bool[]   flags  = { true, false, true };

        PrintArray(arr1, "arr1");
        PrintArray(arr2, "arr2");
        PrintArray(arr3, "arr3");

        Console.WriteLine(arr1);
        Console.WriteLine(arr2);
        Console.WriteLine(arr3);

        Console.WriteLine("names : " + string.Join(", ", names));
        Console.WriteLine(names);

        Console.WriteLine("prices: " + string.Join(", ", prices));
        Console.WriteLine(prices);

        Console.WriteLine("flags : " + string.Join(", ", flags));
        Console.WriteLine(flags);


        // ====================================================
        // CONCEPT 2 — ACCESSING ELEMENTS
        // Indexing starts at 0. Last valid index = Length - 1.
        // Going out of range throws IndexOutOfRangeException at runtime.
        // ====================================================
        Console.WriteLine("\n=== 2. ACCESSING ELEMENTS ===");

        int[] nums = { 10, 20, 30, 40, 50 };

        Console.WriteLine("nums[0] = " + nums[0]);               // first element → 10
        Console.WriteLine("nums[2] = " + nums[2]);               // middle → 30
        Console.WriteLine("nums[4] = " + nums[4]);               // last by index → 50
        Console.WriteLine("nums[nums.Length-1] = " + nums[nums.Length - 1]); // last dynamically → 50
        Console.WriteLine("nums.Length = " + nums.Length);       // total element count → 5


        // ====================================================
        // CONCEPT 3 — MODIFYING ELEMENTS
        // Assign a new value using the index just like a variable.
        // ====================================================
        Console.WriteLine("\n=== 3. MODIFYING ELEMENTS ===");

        int[] data = { 1, 2, 3, 4, 5 };
        data[0] = 100;   // overwrite first
        data[4] = 999;   // overwrite last
        PrintArray(data, "data after modify");   // 100 2 3 4 999


        // ====================================================
        // CONCEPT 4 — LOOPING THROUGH AN ARRAY
        // Use `for` when you need the index.
        // Use `foreach` when you only need the value (cleaner, read-only).
        // ====================================================
        Console.WriteLine("\n=== 4. LOOPING ===");

        int[] marks = { 85, 90, 78, 95, 88 };

        Console.WriteLine("-- for loop (gives index + value) --");
        for (int i = 0; i < marks.Length; i++)
            Console.WriteLine($"  marks[{i}] = {marks[i]}");

        Console.WriteLine("-- foreach loop (value only) --");
        foreach (int m in marks)
            Console.Write(m + " ");
        Console.WriteLine();


        // ====================================================
        // CONCEPT 5 — SUM, MIN, MAX (manual, no built-in)
        // Classic single-pass approach: track running totals/extremes.
        // Seed min and max with the first element before the loop.
        // ====================================================
        Console.WriteLine("\n=== 5. SUM / MIN / MAX ===");

        int[] scores = { 45, 78, 23, 90, 56 };

        int sum = 0;
        int min = scores[0];   // assume first is smallest so far
        int max = scores[0];   // assume first is largest so far

        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
            if (scores[i] < min) min = scores[i];
            if (scores[i] > max) max = scores[i];
        }

        Console.WriteLine("Sum : " + sum);   // 292
        Console.WriteLine("Min : " + min);   // 23
        Console.WriteLine("Max : " + max);   // 90


        // ====================================================
        // CONCEPT 6 — BUILT-IN ARRAY METHODS (System.Array)
        // These are static methods called as Array.MethodName(array, ...)
        // ====================================================
        Console.WriteLine("\n=== 6. BUILT-IN METHODS ===");

        int[] nums2 = { 5, 2, 8, 1, 9, 3 };

        // Sort: ascending order, modifies the array in place
        Array.Sort(nums2);
        PrintArray(nums2, "After Sort");      // 1 2 3 5 8 9

        // Reverse: flips the order, modifies in place
        Array.Reverse(nums2);
        PrintArray(nums2, "After Reverse");   // 9 8 5 3 2 1

        // IndexOf: returns the index of the first match, or -1 if not found
        int pos = Array.IndexOf(nums2, 5);
        Console.WriteLine("Index of 5: " + pos);   // 2

        // Exists: returns true if ANY element satisfies the condition (lambda)
        bool hasLarge = Array.Exists(nums2, x => x > 7);
        Console.WriteLine("Any element > 7? " + hasLarge);   // True

        // Find: returns the FIRST element that satisfies the condition, or default(T)
        int found = Array.Find(nums2, x => x > 7);
        Console.WriteLine("First element > 7: " + found);    // 9

        // Copy: copies `count` elements from source into dest starting at index 0
        int[] source = { 1, 2, 3, 4, 5 };
        int[] dest   = new int[5];
        Array.Copy(source, dest, 5);
        PrintArray(dest, "After Copy");       // 1 2 3 4 5

        // Clear: resets elements to default (0 for int) from startIndex for `count` slots
        Array.Clear(nums2, 0, 2);
        PrintArray(nums2, "After Clear(0,2)");  // 0 0 5 3 2 1

        // Fill: sets every element to the given value
        int[] filled = new int[5];
        Array.Fill(filled, 7);
        PrintArray(filled, "After Fill(7)");  // 7 7 7 7 7


        // ====================================================
        // CONCEPT 7 — ARRAYS ARE REFERENCE TYPES
        // Assigning an array to another variable does NOT copy the data.
        // Both variables point to the SAME memory block.
        // Use Clone() to get a true independent copy.
        // ====================================================
        Console.WriteLine("\n=== 7. REFERENCE TYPE BEHAVIOUR ===");
        
        int[] original = { 1, 2, 3 };
        int[] ref2 = original;   // ref2 and original point to same array
        ref2[0] = 999;
        Console.WriteLine("original[0] after ref2[0]=999 : " + original[0]);  // 999 — both affected!
        
        // Clone() creates a shallow copy — new memory, same values
        int[] trueCopy = (int[])original.Clone();
        trueCopy[0] = 1;
        Console.WriteLine("original[0] after Clone+modify : " + original[0]); // 999 — original untouched


        // ====================================================
        // CONCEPT 8 — PASSING AN ARRAY TO A FUNCTION
        // The reference is passed, so the function sees (and can modify) the original.
        // DoubleAll() doubles every element directly in the caller's array.
        // ====================================================
        Console.WriteLine("\n=== 8. PASSING ARRAY TO A FUNCTION ===");

        int[] myArr = { 10, 20, 30 };
        PrintArray(myArr, "Before DoubleAll");   // 10 20 30
        DoubleAll(myArr);
        PrintArray(myArr, "After  DoubleAll");   // 20 40 60


        // ====================================================
        // CONCEPT 9 — RETURNING AN ARRAY FROM A FUNCTION
        // A function can build and return a brand-new array.
        // GetSquares(5) builds [1, 4, 9, 16, 25] internally and returns it.
        // ====================================================
        Console.WriteLine("\n=== 9. RETURNING ARRAY FROM A FUNCTION ===");

        int[] squares = GetSquares(5);
        PrintArray(squares, "Squares 1..5");   // 1 4 9 16 25


        // ====================================================
        // CONCEPT 10 — 2D ARRAY (rectangular grid)
        // Declared as int[,]  — all rows have the same number of columns.
        // Access: array[row, col]
        // GetLength(0) → row count, GetLength(1) → column count
        // ====================================================
        Console.WriteLine("\n=== 10. 2D ARRAY ===");

        int[,] grid = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("grid[0,0] = " + grid[0, 0]);  // top-left → 1
        Console.WriteLine("grid[1,1] = " + grid[1, 1]);  // center → 5
        Console.WriteLine("grid[2,2] = " + grid[2, 2]);  // bottom-right → 9

        int rows = grid.GetLength(0);   // 3
        int cols = grid.GetLength(1);   // 3
        Console.WriteLine($"Rows={rows}, Cols={cols}");

        // Nested loops to print the full grid
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
                Console.Write(grid[r, c] + " ");
            Console.WriteLine();
        }


        // ====================================================
        // CONCEPT 11 — JAGGED ARRAY (array of arrays)
        // Declared as int[][] — each row is its own array, different lengths allowed.
        // You must allocate each inner array separately.
        // Access: array[row][col]
        // ====================================================
        Console.WriteLine("\n=== 11. JAGGED ARRAY ===");

        int[][] jagged = new int[3][];        // 3 rows, inner size not fixed yet
        jagged[0] = new int[] { 1, 2 };       // row 0 has 2 elements
        jagged[1] = new int[] { 3, 4, 5 };    // row 1 has 3 elements
        jagged[2] = new int[] { 6, 7, 8, 9 }; // row 2 has 4 elements

        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
                Console.Write(jagged[i][j] + " ");
            Console.WriteLine();
        }


        // ====================================================
        // CONCEPT 12 — params KEYWORD
        // Allows a method to accept a variable number of arguments.
        // The caller just passes values separated by commas — no array needed.
        // Internally, C# wraps them into an array for the method.
        // ====================================================
        Console.WriteLine("\n=== 12. params KEYWORD ===");

        Console.WriteLine("SumAll(1,2,3)       = " + SumAll(1, 2, 3));        // 6
        Console.WriteLine("SumAll(10,20,30,40) = " + SumAll(10, 20, 30, 40)); // 100
        Console.WriteLine("SumAll(5)           = " + SumAll(5));               // 5

        Console.WriteLine("\n=== ALL DONE ===");
    }
}