namespace Sem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выравниватель массивов v 0.01");
            Console.WriteLine("Исходный массив выглядит так: ");
            Console.WriteLine(" 7, 3, 2 ");
            Console.WriteLine(" 4, 9, 6 ");
            Console.WriteLine(" 1, 8, 5 ");

            int[,] arr = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
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
            Console.WriteLine(" ");
            Console.WriteLine("Результат сортировки: ");
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    arr[i, j] = sort[counter];
                    counter++;
                    Console.Write(" " + arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}