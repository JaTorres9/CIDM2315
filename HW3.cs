namespace HomeWork3;

class Program
{
    static void Main(string[] args)
    {/*Q1-Input an integer*/

        Console.Write("Input an integer: ");
        int N = int.Parse(Console.ReadLine());

        bool isPrime = IsPrime(N);

        if (isPrime)
        {
            Console.WriteLine($"{N} is prime");
        }
        else
        {
            Console.WriteLine($"{N} is non-prime");
        }

        
        PrintSquarePattern(N);

        PrintSquarePatternRowsOnly(N);
    }
    static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    /*Q2-Assing an int value to to N . rows and columns are equal to N*/
    static void PrintSquarePattern(int N)
    {
        Console.WriteLine("\nAssign an int value to N:");
        {
            Console.WriteLine(N);
        }
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }

    /*Q3- Assign an int value to N. rows are equal to N*/
    static void PrintSquarePatternRowsOnly(int N)
    {
        Console.WriteLine("\nAssign an int value to N:");
         {
            Console.WriteLine(N);
        }
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
