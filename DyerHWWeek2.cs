using System;

namespace DyerHWWeek2
{
class Program
{
    static void Main(string[] args)
    {
        
            //Exercise 1 Output GPA when given letter grade
         //Get user input letter grade
            Console.WriteLine("Please input your letter grade");
            //store user input as variable point
            string point = Console.ReadLine();
            //if user enters A, write GPA 4, etc
            if (point == "A" || point == "a")
            {
                Console.WriteLine("GPA Point: 4");
            }
            else if (point == "B" || point == "b")
            {
                Console.WriteLine("GPA Point: 3");
            }
            else if (point == "C" || point == "c")
            {
                Console.WriteLine("GPA Point: 2");
            }
            else if (point == "D" || point == "d")
            {
                Console.WriteLine("GPA Point: 1");
            }
            else if (point == "F" || point == "f")
            {
                Console.WriteLine("GPA Point: 0");
            }
            else
            {
                Console.WriteLine("Wrong Letter Grade");
            }
        
           

      
            //could not find my error
            //asked ChatGPT to find my error on June 17 - prompt: find the error in my C# code.
            //did not have "" around my letter grades
         

            //Exercise 2 Ask the user to input 3 numbers and print the smallest
            //Ask the user for input
              Console.WriteLine("Please enter 3 numbers - Please press ENTER after each number");
            //store user input 
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("The smallest number is " + num1);
            }
            
            else if (num2 < num3)
            {
                Console.WriteLine("The smallest number is " + num2);
            }
            else
            {
                Console.WriteLine("The smallest number is " + num3);
            }
        
    

    

            //Exercise 3Leap Year
            //Get  user input 
            Console.WriteLine("Please enter a year");
            //store input as year
            int year = Convert.ToInt16(Console.ReadLine());
            //if evenly div by 4, not div by 100 and div by 400
            if(year % 4 == 0  && year % 100 !=0 || year % 400 == 0)
        {    
            Console.WriteLine($"{year} is a Leap Year");
        }
        
            else 
        {
            Console.WriteLine($"{year} is not a Leap Year");
        }   
    }
}
}           // Chat GPT on Exercise 3 - fix my error 6/18. Curly braces trip me up.
    
     





                
            







