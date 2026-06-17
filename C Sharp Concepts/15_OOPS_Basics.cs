// ============================================================
//         OOP STRUCTURE USED IN LEETCODE — C# (RUNNABLE)
// ============================================================

using System;

// ============================================================
//  1. BASIC CLASS — What LeetCode gives you
// ============================================================

public class OopSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
            for (int j = i + 1; j < nums.Length; j++)
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };

        return new int[] { };   // no answer found
    }
}


// ============================================================
//  2. SIGNATURE BREAKDOWN (just a comment, nothing to run)
// ============================================================

//   public   int[]      TwoSum    (int[] nums,   int target)
//     |         |           |           |              |
// access    return       method      parameter 1   parameter 2
// modifier   type         name       (array input) (single int)


// ============================================================
//  3. EXAMPLE CLASS — GetDoubled, AddValueToAll, ReturnTwoIndices
// ============================================================

public class OopExample
{
    public int[] GetDoubled(int[] nums)
    {
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
            result[i] = nums[i] * 2;
        return result;
    }

    public int[] AddValueToAll(int[] nums, int val)
    {
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
            result[i] = nums[i] + val;
        return result;
    }

    public int[] ReturnTwoIndices(int[] nums)
    {
        return new int[] { 0, 3 };  // always returns exactly 2 elements
    }
}


// ============================================================
//  4. MULTIPLE METHODS + PRIVATE HELPER
// ============================================================

public class OopSolution2
{
    private bool IsValid(int[] nums)
    {
        return nums.Length > 0;     // true if array is not empty
    }

    public int[] Process(int[] nums, int target)
    {
        if (!IsValid(nums))
            return new int[] { -1, -1 };  // early return if invalid

        int[] result = new int[2];
        result[0] = 0;
        result[1] = 1;
        return result;
    }
}


// ============================================================
//  5. void vs return type
// ============================================================

public class OopDemo
{
    public void PrintAll(int[] nums)    // void — returns nothing
    {
        foreach (int n in nums)
            Console.Write(n + " ");
        Console.WriteLine();
    }

    public int GetSum(int[] nums)       // int — returns single integer
    {
        int sum = 0;
        foreach (int n in nums) sum += n;
        return sum;
    }

    public int[] GetResult(int[] nums)  // int[] — returns array
    {
        return new int[] { nums[0], nums[nums.Length - 1] };
    }
}


// ============================================================
//  MAIN — all object creation and method calls go HERE
// ============================================================

class OopProgram
{
    static void Main()
    {
        // --- Section 1 & 3: TwoSum ---
        Console.WriteLine("=== TwoSum ===");
        OopSolution sol = new OopSolution();        // create object
        int[] input  = { 2, 7, 11, 15 };
        int   target = 9;
        int[] answer = sol.TwoSum(input, target);   // call method on object
        Console.WriteLine($"TwoSum answer: [{answer[0]}, {answer[1]}]");  // [0, 1]

        // --- Section 4 & 5: OopExample class ---
        Console.WriteLine("\n=== Example class ===");
        OopExample obj = new OopExample();
        int[] input2 = { 1, 2, 3, 4, 5 };

        int[] doubled = obj.GetDoubled(input2);
        Console.Write("GetDoubled:      "); OopPrint(doubled);       // 2 4 6 8 10

        int[] addedFive = obj.AddValueToAll(input2, 5);
        Console.Write("AddValueToAll+5: "); OopPrint(addedFive);     // 6 7 8 9 10

        int[] indices = obj.ReturnTwoIndices(input2);
        Console.Write("ReturnTwoIndices:"); OopPrint(indices);        // 0 3

        // --- Section 5: OopSolution2 with helper ---
        Console.WriteLine("\n=== Solution2 (private helper) ===");
        OopSolution2 sol2 = new OopSolution2();
        int[] res = sol2.Process(new int[] { 3, 5 }, 8);
        Console.Write("Process result:  "); OopPrint(res);           // 0 1

        // --- Section 6: void vs return type ---
        Console.WriteLine("\n=== Demo (void vs return) ===");
        OopDemo demo = new OopDemo();
        int[] sample = { 10, 20, 30, 40 };

        Console.Write("PrintAll:  "); demo.PrintAll(sample);          // 10 20 30 40
        Console.WriteLine("GetSum:    " + demo.GetSum(sample));       // 100
        Console.Write("GetResult: "); OopPrint(demo.GetResult(sample)); // 10 40

        Console.WriteLine("\n=== ALL DONE ===");
    }

    // renamed to OopPrint to avoid clash with PrintArr in other files
    static void OopPrint(int[] arr)
    {
        foreach (int x in arr) Console.Write(x + " ");
        Console.WriteLine();
    }
}