using System;

namespace _4
{
    class Program
    {
        static void Main()
        {

            (int, string) k = (19, "Привет!");
            (int, string, char, string, ulong) k2 = (42, "Я люблю ООП", 'Ы', "Ауе", 141455);
            (double ss, int jjj) k3 = (4.425, 3354);
            Console.WriteLine($"Выборочные элементы k2: {k2.Item1}, {k2.Item3}, {k2.Item4}");
            Console.WriteLine($"Выборочные элементы k3: {k3.ss}, {k3.jjj}");
            Console.WriteLine($"{k.Item1}, {k.Item2}, {k2.Item1}, {k2.Item2}, {k2.Item3}, {k2.Item4}, {k2.Item5}, {k3.ss}, {k3.jjj}");

            var (abb, ff) = k;
            Console.WriteLine($"Распакованный k: {abb}, {ff}");

            var (item1, _, item3, item4, item5) = k2;
            Console.WriteLine($"Распакованный k2: {item1}, {item3}, {item4}, {item5}");

            double ss = k3.ss;
            int jjj = k3.jjj;
            Console.WriteLine($"Распакованный k3: {ss}, {jjj}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            (int x, int y) t1 = (1, 2);
            (int x, int y) t2 = (1, 2);
            (int x, int y) t3 = (1, 3);

            Console.WriteLine(t1 == t2);
            Console.WriteLine(t1 == t3);
            Console.WriteLine(t1 != t3);


        }
    }
}
