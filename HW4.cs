using System;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Q1-returns largest of 2 numbers*/
            int smallest, largest;
            smallest = 3;
            largest = 5;
            Console.WriteLine($"a={smallest}; b={largest}");

            int largestNumber = FindLargestNumber(smallest, largest);
            Console.WriteLine("The largest number is: " + largestNumber);

            /*Q2-enter number and shape*/
            Console.Write("Enter an number : ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type a shape (left or right): ");
            string shape = Console.ReadLine();

            /*Q2-Converts number entered to rows and aligns them based on the shape entered*/
            if (shape == "left")
            {
                Console.WriteLine($"N is: {N}; Shape is {shape}");
                PrintLeftTriangle(N);
            }
            else if (shape == "right")
            {
                Console.WriteLine($"N is: {N}; Shape is {shape}");
                PrintRightTriangle(N);
            }
            else
            {
                Console.WriteLine("Try typing Left or Right");
            }
        }

        static int FindLargestNumber(int num1, int num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }

        static void PrintLeftTriangle(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void PrintRightTriangle(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = N; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
