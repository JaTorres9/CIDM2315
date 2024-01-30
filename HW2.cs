using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Program that assigns GPA Points based on the letter grade the user inputs (A,B,C,D,F) */
            Console.Write("Please input a letter grade: ");
            char grade = char.ToUpper(Console.ReadKey().KeyChar);

            int GPAPoints = GetGPAPoints(grade);

            if (GPAPoints != -1)
            {
                Console.WriteLine($"\nGPA Point: {GPAPoints}");
            }
            else
            {
                Console.WriteLine("\nWrong Letter Grade!");
            }
        }

        static int GetGPAPoints(char grade)
        {
            switch (grade)
            {
                case 'A':
                    return 4;
                case 'B':
                    return 3;
                case 'C':
                    return 2;
                case 'D':
                    return 1;
                case 'F':
                    return 0;
                default:
                    return -1;
            }
        }
    }
}