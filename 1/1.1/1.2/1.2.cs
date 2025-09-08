using System;

namespace lr1
{
    class _2
    {
        static void Main()
        {
            //неявные
            float a = 127;
            double b = a;
            int c = 2147483;
            long d = c;
            char A = 'A';
            int B = A;
            int e = 22533;
            double f = e;
            int g = 12345;
            decimal h = g;
            Console.WriteLine("Неявное приведение");
            Console.WriteLine($"float: {a} -> double: {b}");
            Console.WriteLine($"int: {c} -> long: {d}");
            Console.WriteLine($"char: {A} -> int: {B}");
            Console.WriteLine($"int: {e} -> double: {f}");
            Console.WriteLine($"int: {g} -> decimal: {h}");

            //явные
            double k = 2.569;
            int l = (int)k;
            long m = 345545;
            int n = (int)m;
            int o = 300;
            byte p = (byte)o;
            decimal q = 123.456789m;
            double r = (double)q;
            float t = 99.999f;
            int s = (int)t;
            Console.WriteLine("Явное приведение");
            Console.WriteLine($"double: {k} -> int: {l}");
            Console.WriteLine($"long: {m} -> int: {n}");
            Console.WriteLine($"int: {o} -> byte: {p}");
            Console.WriteLine($"decimal: {q} -> double: {r}");
            Console.WriteLine($"float: {t} -> int: {s}");

            Console.WriteLine("Преобразование при помощи класса Convert");
            int x = Convert.ToInt32("23");
            bool y = true;
            double z = Convert.ToDouble(y);
            Console.WriteLine($"x={x}  z={z}");
        }


    }
}