using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            char opt;

            Console.WriteLine("Choose a calculation : + , - , / , * ");


            //read the full line, and get the first char and store inside opt
            opt = Console.ReadLine()[0];

            Console.WriteLine("Enter number 1");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            num2 = Convert.ToDouble(Console.ReadLine());
            switch (opt)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 * num2));
                    break;

                case '/':
                    if (num2 == 0.0)
                        Console.WriteLine("divide by 0 situation");
                    else
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 / num2));
                    break;
                default:
                    Console.WriteLine("invalid operator");
                    break;
            }

            Console.Write("press any key to exit the program");
            Console.ReadKey();

            // write the statement for choosing the calculation
            //read the statement and store it in a string input
            // check for errors 

            // Write Line for choosing first number
            //check if its an int
            //if not an int return error or try again
            // if its an int store int num1

            // Write Line for choosing second number
            // check if its an int etc
            //store it int to int num2

            // use the int num1 and num2 to perform the calculation, pull the write method 

            /*   do
               {
                   Console.WriteLine("Choose a calculation : +, -, /, *");
                   String typeofCalc = Console.ReadLine();
                   Console.WriteLine("Choose first number");
                   string input = Console.ReadLine();
                  /* while(int.TryParse(input,out int n) == false)
                   {

                   }*/








        }
    }
}
