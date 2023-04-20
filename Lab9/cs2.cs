using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    delegate void MyDelegateText(string message);
    internal class cs2
    {
        public static void task_2 ()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            MyDelegateText displayMessage = new (DisplayMessage);

            
            // Виклик методів через делегат
            displayMessage("Перше повідомлення.");
            displayMessage("Друге повідомлення.");
            displayMessage("Третє повідомлення.");
            DisplayMessage("Четверте повідомлення");
            Console.WriteLine();
        }

        static void DisplayMessage(string a)
        {
            Console.WriteLine(a);
        }
    }
    
}
