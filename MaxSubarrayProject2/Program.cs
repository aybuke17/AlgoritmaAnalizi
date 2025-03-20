using System;

class Program
{
    static int FindMaximumSubarraySum(int[] array)
    {
        int bestSum = array[0];
        int runningSum = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            runningSum = Math.Max(array[i], runningSum + array[i]);
            bestSum = Math.Max(bestSum, runningSum);
        }

        return bestSum;
    }

    static void Main()
    {
        int[] numbers = { -10, 0, 59, 89, -1, 0, 12, 98, 50 };
        Console.WriteLine("Maximum Subarray Sum: " + FindMaximumSubarraySum(numbers));
    }
}
