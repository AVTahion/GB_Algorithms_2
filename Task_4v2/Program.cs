using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  4.  Первая команда увеличивает число на экране на 1, вторая увеличивает его в 2 раза. Определить, сколько существует программ, которые преобразуют число 3 в число 20:
          а. С использованием массива.
          b. *С использованием рекурсии.

    Александр Кушмилов
*/

namespace Task_4v2
{
    class Program
    {
        static int NumberOfSolutions(int start, int end, int p, int m)
        {
            int[] arr = new int[end + 1];
            arr[start] = 1;
            for (int i = start + 1; i <= end; i++)
            {
                arr[i] = i % m == 0 ? arr[i - p] + arr[i / m] : arr[i - p];
            }
            return arr[end];
        }

        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfSolutions(3, 20, 1, 2));
            Console.ReadKey();
        }
    }
}
