using System;

namespace lox
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 100);
            int b = a + 5;
            int c = a - 5;

            int num = 0;

            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num > a && num <= b)
                {
                    Console.WriteLine("Чуть меньше");
                }
                else if (num < a && num >= c)
                {
                    Console.WriteLine("Чуть больше");
                }
                else if (num < a)
                {
                    Console.WriteLine("Слишком мало");
                }
                else if (num > a)
                {
                    Console.WriteLine("Слишком много");
                }
                else if (num == a)
                {
                    Console.WriteLine("Вы угадали");
                }
            } while (num != a);
        }
    }
}
