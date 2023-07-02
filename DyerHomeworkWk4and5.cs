using System;
namespace DyerHomeworkWk4and5;

class Program
{
    static void Main(string[] args)

    {
        int num1 = 3;
        int num2 = 5;
        int num3 = 7;
        int num4 = 9;

        // HW Week4 Q1 find the max value from 2 given numbers by calling a Method
        int max_num = GetMax(num1, num2);
        Console.WriteLine($"{max_num} is the largest number");

        // Q2 4 integers
        int largest_num = GetMaxFour(num1, num2, num3, num4);
        Console.WriteLine($"{largest_num} is the largest number");

        // Q3 Create Account check age and passwords
        createAccount();
    }

    static int GetMax(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }

    // Q2: find the max value from given 4 numbers
    static int GetMaxFour(int num1, int num2, int num3, int num4)
    {
        int max1 = GetMax(num1, num2);
        int max2 = GetMax(num3, num4);
        return GetMax(max1, max2);
    }

    // the CheckAge will be called in the following createAccount() method
    static bool CheckAge(int birth_year)
    {
        int current_year = 2023;
        int age = current_year - birth_year;
        return age > 18;
    }

    static void createAccount()
    {
        Console.WriteLine("Please enter your username");
        string userName = Console.ReadLine();
        Console.WriteLine($"{userName}");

        Console.WriteLine("Please enter your birth year");
        int birth_year = Convert.ToInt32(Console.ReadLine());

        if (CheckAge(birth_year))
        {
            Console.WriteLine("Please enter your password");
            string userPassword1 = Console.ReadLine();
            Console.WriteLine($"{userPassword1}");

            Console.WriteLine("Please enter your password again");
            string userPassword2 = Console.ReadLine();
            Console.WriteLine($"{userPassword2}");

            if (userPassword1 == userPassword2)
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
            Console.WriteLine("Could not create account. You must be over 18 years old.");
        }
    }

}       // July 2 asked ChatGpt to find and fix my errors - still did not run
        //July 2 asked instructor for help - thank you






