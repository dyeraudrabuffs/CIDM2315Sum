using System;
namespace DyerHWWeek3;

class Program
{
    static void Main(string[] args)
    {
       //Excercise 1
        //ask for user input as string
        Console.Write("Input a number: ");
        //Read user input
        string input = Console.ReadLine();
        //convert user input to an integer store as int userInput
        int userInput = Convert.ToInt32(input);

        int num;
        for (num = 2; num <= userInput / 2; num++)
        {
            if (userInput % num == 0)
            {
                break;
            }
        }

        if (num > userInput / 2)
        {
            Console.WriteLine($"{userInput} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{userInput} is non-prime.");
        }




        //Exercise 2
        
        for(int row = 0; row<5; row++)
        {
          for(int col = 0; col <5; col++)
          {
                Console.Write('#');
          }
              Console.WriteLine("");
         }
}
}       
    

                

              



