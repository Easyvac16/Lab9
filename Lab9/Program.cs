namespace Lab9
{
    
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Виберіть яке завдання запустити 1 - Текстове повідомлення , 2 - Калькулятор , 3 - Перевірка чисел , 4 - Калькулятор через Invoke:");
            int a = int.Parse(Console.ReadLine());
            switch(a)
            {
                case 1:
                    cs2.task_2();
                    break;
                case 2:
                    cs1.task_1();
                    break;
                case 3:
                    cs3.task_3();
                    break;
                case 4:
                    cs4.task_4();
                    break;
                default:
                    Console.WriteLine("Помилка");
                    break;
            }

            
            
            
        }
    }
}