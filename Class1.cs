using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleCode
{
    class Class1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Please provide your input1");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Please provide your input2");
            string userInput2 = Console.ReadLine();
            Console.WriteLine("Please provide your input3");
            string userInput3 = Console.ReadLine();

            int a = Convert.ToInt32(userInput1);
            int b = Convert.ToInt32(userInput2);
            int c = Convert.ToInt32(userInput3);

            double s, h;
            s = (a + b + c) / 2;
            h = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("Are using Herons formula " + h);
        }
            
    }
}
