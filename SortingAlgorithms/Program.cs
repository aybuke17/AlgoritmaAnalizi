using System;
using System.Diagnostics;

class Program
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1]) // Move the larger one to the right
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key) // Move the larger one to the right
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }

    static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(minValue, maxValue + 1); 
        }
        return arr;
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }

    static void Main()
    {
        int[] arr = GenerateRandomArray(10000, 1, 1000);


        // Measure the time Bubble Sort
        int[] bubbleArr = (int[])arr.Clone();
        Stopwatch bubbleStopwatch = Stopwatch.StartNew();
        BubbleSort(bubbleArr);
        bubbleStopwatch.Stop();
        Console.WriteLine("\nSorting with Bubble Sort:");
        PrintArray(bubbleArr);
        Console.WriteLine("Bubble Sort Duration: " + bubbleStopwatch.ElapsedMilliseconds + " ms");

        // Measure the time Insertion Sort 
        int[] insertionArr = (int[])arr.Clone();
        Stopwatch insertionStopwatch = Stopwatch.StartNew();
        InsertionSort(insertionArr);
        insertionStopwatch.Stop();
        Console.WriteLine("\nSorting with Insertion Sort:");
        PrintArray(insertionArr);
        Console.WriteLine("Insertion Sort Duration: " + insertionStopwatch.ElapsedMilliseconds + " ms");
    }
}
