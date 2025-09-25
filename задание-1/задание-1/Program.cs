using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите количество элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите элемент [{i}]: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
