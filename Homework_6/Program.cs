/// Chapter No. 11 - Homework7
/// File Name: Homework_7.java
/// @author: Rossana Palma
/// Date:  October 9, 2021
///
/// Problem Statement:  Define a class called Counter whose objects count things.
/// An object of this class records a count that is a nonnegative integer. 
/// Include methods to set the counter to 0, to increase the count by 1, and to 
/// decrease the count by 1.  Include a getter method that returns the current
/// count value and a method that outputs the count to the screen. Include a 
/// ToString methods and a Equals method.  Write a driver program that include a 
/// menu to interactively test each method in your program.
/// 
/// Overall Plan:
/// 1) Create a Counter class
/// 2) Create methods to set the counter to 0, to increase by 1 and decrease by 1.
/// 3) Create a getter method that return the current value
/// 4) Create a method to display the count to the screen
/// 5) Create ToString and a Equals method
/// 6) In main create an interactive menu to test each method

using System;

namespace Homework_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            
            Counter test = new Counter();
                                   
            while (option != 4)
            {
                Console.WriteLine("\nInteractive test.\n");
                Console.WriteLine("1. Display Counter");
                Console.WriteLine("2. Increase by 1");
                Console.WriteLine("3. Decrease by 1");
                Console.WriteLine("4. Reset counter to 0");
               
                // Prompt user for option and convert it to int
                Console.Write("\nEnter option: ");
                option = Convert.ToInt32(Console.ReadLine());
               
                switch (option)
                {

                    case 1:
                        test.displayCounter();
                        //Console.WriteLine("");
                        break;

                    case 2:
                        test.increaseCounter();
                        Console.WriteLine("\nIncrease by 1: " + test.ToString());
                        break;
                    
                    case 3:
                        if (test.getCounter() == 0)
                        {
                            Console.WriteLine("\nInvalid input.");
                        }
                        else if (test.getCounter() != 0)
                        {
                            Console.WriteLine("\nDecrease by 1: ");
                        }
                        test.decreaseCounter();
                        Console.WriteLine(test.ToString());
                        break;
                    
                    case 4:
                        test.resetCounter();
                        Console.WriteLine("Reset to 0: " + test.ToString());
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }

            Console.ReadLine();  
        }
    }
}

    
    


