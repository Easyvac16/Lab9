namespace Lab9
{
    public delegate int MyDelegate(int a, int b);
    internal class Program
    {
        public static int Add(int a, int b)
        {
           return a + b;
        }
        public static int Substract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        static void Main()
        {
            MyDelegate myDelegate;
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
                    res = myDelegate(b,f);
                    break;
                case "-":
                    myDelegate = Substract;
                    res = myDelegate(b, f);
                    break;
                case "*":
                    myDelegate = Multiply;
                    res = myDelegate(b, f);
                    break;
                case "/":
                    myDelegate = Divide;
                    res = myDelegate(b, f);
                    break;
                default:
                    Console.WriteLine("Error...");
                    break;
            }
            
            Console.WriteLine( $"Result:{res}");

        }
    }
}