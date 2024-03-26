using System;

class Program
{
    //*** Do NOT change the code in Main ***
    public static void Main(string[] args)
    {
        // Test Q1
        int[] int_array = { 11, 23, 31, 42, 53 };
        ArraySum(int_array);
        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        // Test Q2.1
        PrintAllOddNumber(array_2d);
        // Test Q2.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");
        // Test Q2.3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        for (int i = 0; i < Q2_3.GetLength(0); i++)
        {
            for (int j = 0; j < Q2_3.GetLength(1); j++)
            {
                Console.Write(Q2_3[i, j] + " ");
            }
        }
    }
    // **Complete the following methods, then run the program to check outputs**
    // Q1: calculate the sum of elements in a given int_array (4 points)
    public static void ArraySum(int[] int_array)
    {
        int sum = 0;
        foreach (int num in int_array)
        {
            sum += num;
        }
        Console.WriteLine($"Sum of elements in the array: {sum}");
    }
    //Q2.1: given a 2d array, print all the odd elements (2 points)
    public static void PrintAllOddNumber(int[,] array_2d)
    {
        Console.WriteLine("Odd elements in the array:");
        for (int i = 0; i < array_2d.GetLength(0); i++)
        {
            for (int j = 0; j < array_2d.GetLength(1); j++)
            {
                if (array_2d[i, j] % 2 != 0)
                {
                    Console.WriteLine(array_2d[i, j]);
                }
            }
        }
    }
    //Q2.2: given a 2d array, return the sum of all elements (2 points)
    public static int ElementSum(int[,] array_2d)
    {
        int sum = 0;
        for (int i = 0; i < array_2d.GetLength(0); i++)
        {
            for (int j = 0; j < array_2d.GetLength(1); j++)
            {
                sum += array_2d[i, j];
            }
        }
        return sum;
    }
    // Q2.3: given a 2d array, double its element values and return it (2 points)
    public static int[,] DoubleArray(int[,] array_2d)
    {
        int[,] doubledArray = new int[array_2d.GetLength(0), array_2d.GetLength(1)];
        for (int i = 0; i < array_2d.GetLength(0); i++)
        {
            for (int j = 0; j < array_2d.GetLength(1); j++)
            {
                doubledArray[i, j] = array_2d[i, j] * 2;
            }
        }
        return doubledArray;
    }
}
