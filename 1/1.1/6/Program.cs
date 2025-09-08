using System;

class Program
{
    static void Main()
    {
        void checkedf()
        {
            checked
            {
                int x = int.MaxValue;
                x = x + 1;
            }
        }

        void uncheckedf()
        {
            unchecked
            {
                int x = int.MaxValue;
                x = x + 1;
                Console.WriteLine("Результат без проверки: " + x);
            }
        }
        try
        {
            checkedf();
        }
        catch
        {
            Console.WriteLine("Ошибка переполнения в checked!");
        }
        uncheckedf();
    }
}