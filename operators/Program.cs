using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number : ");
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Second number : ");
            double num2=Convert.ToDouble(Console.ReadLine());
            string op = ("+,-,*,/");
            Console.WriteLine("Enter operator: "+ op);
            op = Console.ReadLine();
           

            if(op == "+")
            {
                Console.WriteLine(num1+num2);
            }
            else if(op == "-")
            {
                Console.WriteLine(num1 - num2);

            }
            else if( op == "*")
            {
                Console.WriteLine(num1 * num2);

            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }

        }
    }
}
