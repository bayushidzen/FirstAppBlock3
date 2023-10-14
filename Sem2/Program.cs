using Sem2;
using System.Drawing;

namespace Sem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выравниватель массивов v 0.03");


            Console.WriteLine("{0,15}", "МЕНЮ");
            Console.WriteLine("Как вы хотите создать массив?");
            Console.WriteLine("{0,10}", "1) Вручную 2) Автоматически");
            int.TryParse(Console.ReadLine(), out int number);

            Console.WriteLine("Укажите размерность массива: ");
            int.TryParse(Console.ReadLine(), out int arrSize);
            int[,] arr = new int[arrSize, arrSize];
            switch (number)
            {
                case 1:
                    Console.Clear();
                    ManualGenerator(arrSize, arr);
                    Console.WriteLine("Вы ввели такой массив: ");
                    PrinArray(arr);
                    break;
                case 2:
                    Console.Clear();
                    AutoGenerator(arrSize, arr);
                    Console.WriteLine("Автоматически сгенерирован массив: ");
                    PrinArray(arr);
                    break;
                default:
                    Console.WriteLine("Для использования программы выберите режим ручной или автоматический");
                    break;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Результат сортировки: ");
            SortArray(arr);
            PrinArray(arr);
        }
        public static void ManualGenerator(int size, int[,] arr)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine("Введите элемент массива и нажмите Enter: ");
                    int.TryParse(Console.ReadLine(), out int arrMember);
                    arr[i, j] = arrMember;
                }
            }
        }
        public static void AutoGenerator(int size, int[,] arr)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = new Random().Next(0, 101);
                }
                Console.WriteLine();
            }
        }
        public static void PrinArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" " + arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void SortArray(int[,] arr)
        {
            int y = arr.GetLength(0);
            int x = arr.GetLength(1);

            int[] sort = new int[x * y];
            int counter = 0;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    sort[counter] = arr[i, j];
                    counter++;
                }
            }
            Array.Sort(sort);
            counter = 0;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    arr[i, j] = sort[counter];
                    counter++;
                }
            }
        }
    }
}