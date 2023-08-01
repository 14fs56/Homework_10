using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    class Program
    {
        static void Main()
        {
            bool[] thimbles = { false, false, true };
            Console.WriteLine("Игра в наперстки\n");
            Console.WriteLine("под одним из трех наперстков находится шарик. Попробуйте угадать в каком!\n");
            Console.Write("Введите ваше число от 1 до 3: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (thimbles[input - 1])
            {
                Console.WriteLine("Да! Вы нашли шарик!");
            }
            else
            {
                Console.WriteLine("Нет! Вы не угадали!");
            }
        }
    }
}
