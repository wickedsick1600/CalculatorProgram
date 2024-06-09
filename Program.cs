using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("| Hello! Welcome to My Calculator Program |");
            Console.WriteLine("-------------------------------------------");

            double num1;
            double num2;

            double result;

            do{
                
                Console.WriteLine("Please enter your first number");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter your second number");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please select the operation you want to use");
                Console.WriteLine(" + for addition");
                Console.WriteLine(" - for subtraction");
                Console.WriteLine(" * for multiplication");
                Console.WriteLine(" / for division");

                Console.Write("Please enter your selection: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"{num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"{num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"{num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("You have entered an invalid response");
                        break;
                }
                Console.WriteLine("Would you like to continue using the Calculator Program? (Y/N)");
            }while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Thank you for using the program");         

            Console.ReadKey();
        }
    }
}
