using System;

namespace _5
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 10, 3, 22, 5 };
            string str = "Привет! Как дела?";
            var res = sortir(arr, str);

            (int max, int min, int sum, char first) sortir(int[] arr2, string str2)
            {
                int max2=0, min2=0, sum2=0;
                char firs2='\0';

                for (int i=0; i<5; i++)
                {
                    if (arr2[i] > max2)
                        max2 = arr2[i];

                    if (arr2[i] < min2)
                        min2 = arr2[i];

                    sum2 += arr2[i];
                }


                if (!string.IsNullOrEmpty(str2))
                {
                    firs2 = str2[0];
                }

                return (max2, min2, sum2, firs2);


            }

            Console.WriteLine($"Максимальный элемент: {res.max}");
            Console.WriteLine($"Минимальный элемент: {res.min}");
            Console.WriteLine($"Сумма элементов: {res.sum}");
            Console.WriteLine($"Первая буква строки: '{res.first}'");


        }
    }
}
