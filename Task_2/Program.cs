using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  2.  Реализовать функцию возведения числа a в степень b:
          - Без рекурсии.
          - Рекурсивно.
          -*Рекурсивно, используя свойство чётности степени.
    3.  **Исполнитель «Калькулятор» преобразует целое число, записанное на экране. У исполнителя две команды, каждой присвоен номер: 
          1. Прибавь 1.
          2. Умножь на 2.
    4.  Первая команда увеличивает число на экране на 1, вторая увеличивает его в 2 раза. Определить, сколько существует программ, которые преобразуют число 3 в число 20:
          а. С использованием массива.
          b. *С использованием рекурсии.

    Александр Кушмилов
*/

namespace Task_2
{
    class Program
    {
        /// <summary>
        /// Метод возводит число a в степень b
        /// </summary>
        /// <param name="a">число a</param>
        /// <param name="b">степень b</param>
        /// <returns></returns>
        static int Pov(int a, int b)
        {
            int c = a;
            for (int i = 0; i < b-1; i++)
            {
                c = c * a;
            }
            return c;
        }

        /// <summary>
        /// Метод возводит число a в степень b
        /// </summary>
        /// <param name="a">число a</param>
        /// <param name="b">степень b</param>
        /// <returns></returns>
        static int PovRe(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            else
            {
                return PovRe(a, b-1) * a;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Pov(a, b);
            Console.WriteLine(c);
            int d = PovRe(a, b);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
