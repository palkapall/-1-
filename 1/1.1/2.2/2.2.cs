using System;
using System.Text;
namespace _2._2
{
    class Program
    {
        static void Main()
        {
            string firstname = "Polina";
            string lastname = "Kunevich";
            string Dad = "Henadzievna";
            string operations;
            string[] values = new string[] { firstname, lastname, Dad };

            operations = firstname + " " + lastname;
            Console.WriteLine(operations);

            string s1 = string.Join(" ", values);
            Console.WriteLine(s1);

            int result = string.Compare(lastname, firstname);
            if (result < 0)
            {
                Console.WriteLine("Строка s1 перед строкой s2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }

            int search = firstname.IndexOf('o');
            Console.WriteLine(search);
            int search2 = lastname.IndexOf('Z');
            Console.WriteLine(search2);

            string copied = string.Copy(firstname);
            Console.WriteLine($"Копирование: оригинал='{firstname}', копия='{copied}'");

            string substring = operations.Substring(6, 5);
            Console.WriteLine($"Подстрока: {substring}");

            string text = "Самая крупная жемчужина в мире достигает 6 килограммов в весе.";
            string[] words = text.Split(' ');
            Console.WriteLine("Разделение на слова:");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"   - {words[i]}");
            }

            string str = "Polina ";
            string removed = operations.Replace(str, "");
            Console.WriteLine($"Удаление: {removed}");

            //интерпелирование строк
            int a = 5, b = 11;
            Console.WriteLine($"a+b={a + b}");
            double lal = 12345.67;
            Console.WriteLine($"{lal:C}"); // Валюта
            Console.WriteLine($"{lal:F2}"); // 2 знака после запятой


            string s11 = "LALALALLALA";
            string s12 = "";
            string s13 = null;
            string[] s = { s11, s12, s13 };

            for (int i = 0; i < s.Length; i++)
            {
                if (String.IsNullOrEmpty(s[i]))
                {
                    Console.WriteLine($"s1{i + 1}: Пустая или null");
                }
                else
                {
                    Console.WriteLine($"s1{i + 1}: Не пусто, не null");
                }
            }

            StringBuilder sb = new StringBuilder("Я люблю ООП!!");
            Console.WriteLine(sb);
            sb.Append(" А еще люблю БД!!");
            Console.WriteLine(sb);
            sb.Insert(2, "очень ");
            Console.WriteLine(sb);
            sb.Remove(7, 18);
            Console.WriteLine(sb);

        }
    }
}