using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    delegate bool NumericPredicate(int number);
    internal class cs3
    {
        public static void task_3()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            NumericPredicate isEven = n => n % 2 == 0;

            Console.WriteLine("Введіть число для перевірки на парність");
            int num1 = int.Parse(Console.ReadLine());

            if (isEven(num1))
            {
                Console.WriteLine($"{num1} є парним числом.");
            }
            else
            {
                Console.WriteLine($"{num1} не є парним числом.");
            }
            Console.WriteLine();

            // Перевірка числа на непарність
            NumericPredicate isOdd = n => n % 2 != 0;

            Console.WriteLine("Введіть число для перевірки на непарність");
            int num2 = int.Parse(Console.ReadLine());
            if (isOdd(num2))
            {
                Console.WriteLine($"{num2} не непарним числом.");
            }
            else
            {
                Console.WriteLine($"{num2} є непарним числом.");
            }
            Console.WriteLine();

            // Перевірка на просте число
            NumericPredicate isPrime = n =>
            {
                if (n <= 1) return false;
                if (n == 2) return true;
                if (n % 2 == 0) return false;
                for (int i = 3; i <= Math.Sqrt(n); i += 2)
                {
                    if (n % i == 0) return false;
                }
                return true;
            };

            Console.WriteLine("Введіть число для перевірки чи є число просте");
            int num3 = int.Parse(Console.ReadLine());
            if (isPrime(num3))
            {
                Console.WriteLine($"{num3} є простим числом.");
            }
            else
            {
                Console.WriteLine($"{num3} не є простим числом.");
            }
            Console.WriteLine();

            // Перевірка на число Фібоначчі
            NumericPredicate isFibonacci = n =>
            {
                int a = 0;
                int b = 1;
                while (b < n)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                return b == n;
            };

            Console.WriteLine("Введіть число для перевірки чи є число числом Фібоначчі");
            int num4 = int.Parse(Console.ReadLine());
            if (isFibonacci(num4))
            {
                Console.WriteLine($"{num4} є числом Фібоначчі.");
            }
            else
            {
                Console.WriteLine($"{num4} не є числом Фібоначчі.");
            }
            Console.WriteLine();

        }
    }
}
