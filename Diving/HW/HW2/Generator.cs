using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2
{
    internal class Generator
    {
        public static int[,] AutoGenerator() {

            Console.WriteLine("Укажите размерность массива: ");
            int.TryParse(Console.ReadLine(), out int arrSize);
            int[,] arrAuto = new int[arrSize, arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                for (int j = 0; j < arrSize; j++)
                {
                    Console.Write(" " + arrAuto[i, j] + " ");
                }
                Console.WriteLine();
            }
            return arrAuto;
        }
    }
}
