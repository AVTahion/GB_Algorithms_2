using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  1.  Реализовать функцию перевода чисел из десятичной системы в двоичную, используя рекурсию.
    2.  Реализовать функцию возведения числа a в степень b:
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

namespace GB_Algorithms_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            string res = String.Empty;
            BinaryTranslation(Convert.ToUInt32(Console.ReadLine()), ref res);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        /// <summary>
        /// Метод перевода чисел из десятичной системы в двоичную.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="res"></param>
        static void BinaryTranslation(uint x, ref string res)
        {
            if (x == 0)
            {
                char[] arr = res.ToArray();
                res = String.Empty;
                for (int i = arr.Length-1; i >= 0;  i--)
                {
                    res += arr[i];
                }
                return;
            }
            else
            {
                res += x % 2;
                BinaryTranslation(x / 2, ref res);
            }
        }
    }
}
