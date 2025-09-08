using System;


namespace _3
{
    class Program
    {
        static void Main()
        {
            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int rows = arr1.GetLength(0);
            int cols = arr1.GetLength(1);

            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int[] arr2 = { 1, 2, 3, 4, 5 };
            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Длина массива: {arr2.Length}");

            Console.WriteLine("Введите позицию, которую хотите заменить");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число на которое хотите заменить");
            int b = Convert.ToInt32(Console.ReadLine());

            arr2[a] = b;
            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int[][] arr3 = new int[3][];
            arr3[0] = new int[2];
            arr3[1] = new int[3];
            arr3[2] = new int[4];

            Console.WriteLine("Введите значения для массива:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr3[i].Length; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    arr3[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr3[i].Length; j++)
                {
                    Console.Write($"{arr3[i][j]} \t ");
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var h = new[] { 0, 1, 2 };

            foreach (int i in h)
            {
                Console.WriteLine(i);
            }

            var strarr = new[] { "Привет,", "я Полина", "!" };

            foreach (string i in strarr)
            {
                Console.WriteLine(i);
            }

            var arr4 = new[,] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arr4[i, j]} \t ");
                }
                Console.WriteLine();
            }


        }
    }
}
