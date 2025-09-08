using System;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.4
            var i = 11;
            var s = "LOL";
            var a = new[] { 0, 1, 2 };
            var chel = new { Name = "Terry", Age = 34 };

            //1.5
            char? val = null;
            Console.WriteLine($"{val}");
            val = 'D';
            Console.WriteLine($"{val}");

            //1.6
            var age = 19; // var сам определяет тип переменной age уже имеет тип int
            age = "Polina"; // и не может иметь тип string

        }
    }
}
