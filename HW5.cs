using System;

class Program
{
    static int GetLargestInteger(int num1 = 0, int num2 = 0)
    {/*Q1*/
        return (num1 > num2) ? num1 : num2;
    }

    static int GetLargestInteger(int a, int b, int c, int d)
    {/*Q2*/
        int max1 = GetLargestInteger(a, b);
        int max2 = GetLargestInteger(c, d);
        return GetLargestInteger(max1, max2);
    }

    static bool CheckAge(int birthYear)
    {/*Q3 part 1*/
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;
        return age >= 18;
    }

    static void CreateAccount()
    {/*Q3 part 1*/
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string password1 = Console.ReadLine();

        Console.WriteLine("Enter password again:");
        string password2 = Console.ReadLine();

        Console.WriteLine("Enter birth year:");
        int birthYear;
        if (!int.TryParse(Console.ReadLine(), out birthYear))
        {
            Console.WriteLine("Invalid input for birth year.");
            return;
        }

        if (CheckAge(birthYear))
        {
            if (password1 == password2)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }

    static void Main(string[] args)
    {
        /*Call & print the result of the first method*/
        Console.WriteLine("The largest integer is: " + GetLargestInteger());

        /*Call & print the result of the second method*/
        Console.WriteLine("The largest integer is: " + GetLargestInteger(1, 2, 3, 4));

        /*Call the createAccount method*/
        CreateAccount();
    }
}
