using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public delegate int MyDelegate(int a, int b);
    internal class cs1
    {
        public static void task_1()
        {
            static int Add(int a, int b)
            {
               return a + b;
            }

            static int Substract(int a, int b)
            {
                return a - b;
            }
            static int Multiply(int a, int b)
            {
                return a * b;
            }
            static int Divide(int a, int b)
            {
                return a / b;
            }
       
        
            MyDelegate myDelegate = null;
            int res = 0;
            Console.WriteLine("Write first number:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Write second number:");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("What operation you want to do:+ - / *");
            string a = Console.ReadLine();

            switch (a)
            {
                case "+":
                    myDelegate = Add;
                    break;
                case "-":
                    myDelegate = Substract;
                    break;
                case "*":
                    myDelegate = Multiply;
                    break;
                case "/":
                    myDelegate = Divide;
                    break;
                default:
                    Console.WriteLine("Error...");
                    break;
            }
            res = myDelegate(b, f);
            Console.WriteLine( $"Result:{res}");
            Console.WriteLine();


        }
    }
}
