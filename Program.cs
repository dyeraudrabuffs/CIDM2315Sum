using System;
namespace DyerHomeworkWk4and5;

class Program
{
    static void Main(string[] args)
{

//HW Week4 Q1 find the max value from 2 given numbers by calling a Method
          int num1, num2;
                num1=3;
                num2=5;
            int max_num=GetMax(num1, num2);
                Console.WriteLine($"{max_num} is the largest number");

        static int GetMax(int num1, int num2) //define method GetMax
            {
                if(num1>num2)
            {
                return num1;
            }
                else
            {
                return num2;
            }
            }


    // Q2 4 integers
            int num1, num2, num3, num4;
                num1=3;
                num2=5;
                num3=7;
                num4=9;
            int max1=GetMax(num1, num2); //method GetMax
            int max2=GetMax(num3, num4); //method GetMax
            int largest_num=GetMax(max1, max2); //method GetMax
                Console.WriteLine($"{largest_num} is the largest number");
        }
        }


        static int GetMax(int num1, int num2) //define method GetMax
        {
                if(num1>num2)
        {
        return num1;
        }
                else
            {
                return num2;
            }
        



//Q3 1. check age using bool checkAge - Homework Q3
            Console.WriteLine("Please enter your birth year");


        int birth_year = Convert.ToInt32(Console.ReadLine());
            bool oldEnough = CheckAge(birth_year);
            Console.WriteLine($"{oldEnough}");
            }

            static bool CheckAge(int birth_year)
            {
            int current_year=2023;
            int age = current_year - birth_year;
            if(age>18)
            {
            return true;
            }
            else
            {
            return false;
            }
            }

            //Q3 Create Account check age and passwords
           
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
                Console.WriteLine("Could not create an account");
            }
        }
        else
        {
            Console.WriteLine("Account could not be created. You must be over 18 years old.");
        }
    }

    static bool CheckAge(int birth_year)
    {
        int current_year = 2023; 
        int age = current_year - birth_year;
        return age > 18;
    }











