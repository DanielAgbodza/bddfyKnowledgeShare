using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        public static int add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
