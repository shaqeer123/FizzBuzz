using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaqeer_hotmail.co.uk
{
    class Program 
    {
        //initializing constructor class
        public Program() {}
        
        static void Main(string[] args)
        {           
            /*I have developed an overloaded function for this technical task
              the function name is, liveNation().

              the first implemented version takes no parameters within the paranthasis
              and has the number range 1 - 20. 

              the second version takes a string parameter, 
              this version will take user input and use 
              the numbers provided will be the number range. 

              The third version of the function liveNation() takes two Parameters,
              a string and a number, This version will take in user input and 
              unlike the others. it will sort the number range, just in case 
              the first number given is higher then the second. also if both
              numbers are the same value it will not run and will prompt 
              you to try again. 
            */

            liveNation(); // version one
            liveNation("hi"); // version two
            liveNation("hi", 5); // version three
        }

        //Overloading
        static void liveNation()
        {
            // number range equals 1 to 20 for this function
            //Int counters to record Results
            int fizzBuzz = 0, fizz = 0, buzz = 0, interger = 0;

            #region Developing a for loop to gain and print out Results 
            Console.WriteLine("Results: ");
            for (int i = 1; i <= 20; i++)
            {
                /* applying a set of rules to each number in the range and returns the result.
                through each interation I am also recording the satistical results
                If the input number is a multiple of 3 and 5 then output “fizzbuzz” */
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                    fizzBuzz++;
                }

                //If the input number is a multiple of 3 then output “fizz”
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    fizz++;
                }

                //If the input number is a multiple of 5 then output “buzz”
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                    buzz++;
                }

                //if no rule matches, then output the input number 
                else
                {
                    Console.WriteLine(i);
                    interger++;
                }
            }
            #endregion

            #region Printing out Summary
            Console.WriteLine(); //creating a gap
            Console.WriteLine("Summary: ");
            Console.WriteLine("Fizz: " + fizz);
            Console.WriteLine("Buzz: " + buzz);
            Console.WriteLine("FizzBuzz: " + fizzBuzz);
            Console.WriteLine("Interger: " + interger);
            #endregion
        }

        static void liveNation(String Name)
        {
            #region Accepting number range/ Retrieving user input
            /* Develop a C# console app that accepts a number range, 
            Recieving user input for console to accept, 
            this number will be stored within int a */
            int a, b;
            Console.WriteLine("Please Enter low number range");
            a = Convert.ToInt32(Console.ReadLine());

            //Recieving user input for console to accept, 
            //this number will be stored within int b
            Console.WriteLine("Please Enter High Number range");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); // To create a line gap
            #endregion

            //Int counters to record Results
            int fizzBuzz = 0, fizz = 0, buzz = 0, interger = 0;

            #region Developing a for loop to gain and print out Results 
            Console.WriteLine("Results: ");
            for (int i = a; i <= b; i++)
            {
                /* applying a set of rules to each number in the range and returns the result.
                through each interation I am also recording the satistical results
                If the input number is a multiple of 3 and 5 then output “fizzbuzz” */
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                    fizzBuzz++;
                }

                //If the input number is a multiple of 3 then output “fizz”
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    fizz++;
                }

                //If the input number is a multiple of 5 then output “buzz”
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                    buzz++;
                }

                //if no rule matches, then output the input number 
                else
                {
                    Console.WriteLine(i);
                    interger++;
                }
            }
            #endregion

            #region Printing out Summary
            Console.WriteLine(); //creating a gap
            Console.WriteLine("Summary: ");
            Console.WriteLine("Fizz: " + fizz);
            Console.WriteLine("Buzz: " + buzz);
            Console.WriteLine("FizzBuzz: " + fizzBuzz);
            Console.WriteLine("Interger: " + interger);
            #endregion
        }

        static void liveNation(String Name, int z)
        {
            #region Accepting number range/ Retrieving user input
            /* Develop a C# console app that accepts a number range, 
            Recieving user input for console to accept, 
            this number will be stored within int a */
            int a, b, c;

            //trigger that does not allow function to run if range is identical number e.g (0,0)
            bool summary = true;

            Console.WriteLine("Please Enter low number range");
            a = Convert.ToInt32(Console.ReadLine());

            //Recieving user input for console to accept, 
            //this number will be stored within int b
            Console.WriteLine("Please Enter High Number range");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); // To create a line gap
            #endregion

            #region If statment to Sort number range incase first number is higher than second
            //sorting number range, low to high
            if (a > b)
            {
                c = a;
                a = b;
                b = a;
            }
            
            //if both inputs are the same value
            else if (a == b)
            {
                Console.WriteLine("Numbers cannot equal the same value");
                liveNation("hi", 5);
                summary = false;
            }

            else
            {
                summary = true;
            }
            #endregion

            //Int counters to record Results
            int fizzBuzz = 0, fizz = 0, buzz = 0, interger = 0;

            if (summary == true)
            {
                Console.WriteLine("Results: ");
                #region Developing a for loop to gain and print out Results 
                for (int i = a; i <= b; i++)
                {
                    /* applying a set of rules to each number in the range and returns the result.
                    through each interation I am also recording the satistical results
                    If the input number is a multiple of 3 and 5 then output “fizzbuzz” */
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("Fizzbuzz");
                        fizzBuzz++;
                    }

                    //If the input number is a multiple of 3 then output “fizz”
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                        fizz++;
                    }

                    //If the input number is a multiple of 5 then output “buzz”
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("buzz");
                        buzz++;
                    }

                    //if no rule matches, then output the input number 
                    else
                    {
                        Console.WriteLine(i);
                        interger++;
                    }
                }
                #endregion

                #region Printing out Summary
           
                    Console.WriteLine(); //creating a gap
                    Console.WriteLine("Summary: ");
                    Console.WriteLine("Fizz: " + fizz);
                    Console.WriteLine("Buzz: " + buzz);
                    Console.WriteLine("FizzBuzz: " + fizzBuzz);
                    Console.WriteLine("Interger: " + interger);
                #endregion
            }

        }

        //initializing Destructor class
        ~Program() {}
    }
}
