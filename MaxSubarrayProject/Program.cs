using System;

class Program
{
    static int FindMaxSum(int[] arr, int low, int high)
    {
        if (low == high)
            return arr[low];

        int mid = (low + high) / 2;

        int leftMax = FindMaxSum(arr, low, mid);
        int rightMax = FindMaxSum(arr, mid + 1, high);
        int crossMax = MaxCrossingSum(arr, low, mid, high);

        return Math.Max(leftMax, Math.Max(rightMax, crossMax));
    }

    static int MaxCrossingSum(int[] arr, int low, int mid, int high)
    {
        int leftSum = int.MinValue, rightSum = int.MinValue, sum = 0;

        for (int i = mid; i >= low; i--)
        {
            sum += arr[i];
            if (sum > leftSum)
                leftSum = sum;
        }

        sum = 0;
        for (int i = mid + 1; i <= high; i++)
        {
            sum += arr[i];
            if (sum > rightSum)
                rightSum = sum;
        }

        return leftSum + rightSum;
    }

    static void Main()
    {
        int[] arr = { -10, 0, 59, 89, -1, 0, 12, 98, 50 };
        int maxSum = FindMaxSum(arr, 0, arr.Length - 1);
        Console.WriteLine("Maximum Subarray Sum: " + maxSum);
    }
}
