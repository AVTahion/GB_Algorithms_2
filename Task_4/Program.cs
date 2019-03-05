using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_4
{
    class Program
    {
        /// <summary>
        /// Метод прибавляет единицу.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static int AddOne(int x)
        {
            return x + 1;
        }

        /// <summary>
        /// Метод умнажает на 2.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static int MultiplyTwo(int x)
        {
            return x * 2;
        }

        //‭Макс последовательность команд для получения 20 из 3: bin 1 1111 1111 1111 1111 = dec 131071‬

        /// <summary>
        /// Метод проверяет все возможные комбинации двух действий +1 и *2 приводящие 3 к 20,
        /// Находит не все последовательности т.к. не генерирует последовательности с ведущими нулями
        /// </summary>
        /// <returns></returns>
        static int NumberOfSolutions()
        {
            int NOS = 0;
            int res;
            string comSequenceBin;
            char[] cSBArray;

            for (int i = 0; i < 131072; i++)
            {
                comSequenceBin = String.Empty;
                res = 3;
                GB_Algorithms_2.Program.BinaryTranslation((uint)i, ref comSequenceBin);
                cSBArray = comSequenceBin.ToArray();
                for (int k = 0; k < cSBArray.Length; k++)
                {
                    int test = (int)Char.GetNumericValue(cSBArray[k]);
                    res = test == 0 ? MultiplyTwo(res) : AddOne(res);
                    if (res > 20) break;
                }
                if (res == 20)
                {
                    Console.WriteLine(i);
                    NOS++;
                }

            }
            return NOS;
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
            int num = NumberOfSolutions();
            Console.WriteLine("done");
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
