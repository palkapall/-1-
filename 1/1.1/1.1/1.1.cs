using System;
namespace lr1
{
    class Program
    {
        static void Main()
        {
            //типы Для цифр отличаются ток размером
            byte a = 255;
            sbyte b = -128;
            short c = -32768;
            ushort d = 65535;
            int e = -2147483648;
            uint f = 4294967295;
            long g = -9223372036854775808;
            ulong h = 18446744073709551615;
            float j = 3.14f;
            double k = 3.141592653589793;
            decimal l = 3.14159265358979323846m;
            char m = 'A';
            bool n = true;
            string o = "Hello, World!";
            object p = "This is an object";
            Console.WriteLine($"byte: {a}");
            Console.WriteLine($"sbyte: {b}");
            Console.WriteLine($"short: {c}");
            Console.WriteLine($"ushort: {d}");
            Console.WriteLine($"int: {e}");
            Console.WriteLine($"uint: {f}");
            Console.WriteLine($"long: {g}");
            Console.WriteLine($"ulong: {h}");
            Console.WriteLine($"float: {j}");
            Console.WriteLine($"double: {k}");
            Console.WriteLine($"decimal: {l}");
            Console.WriteLine($"char: {m}");
            Console.WriteLine($"bool: {n}");
            Console.WriteLine($"string: {o}");
            Console.WriteLine($"object: {p}");
        }
    }
}