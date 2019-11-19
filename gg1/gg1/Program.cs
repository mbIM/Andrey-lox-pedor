using System;

namespace gg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int b = 1;
            int temp = 0;
            int c = 100;
            int a = rnd.Next(b, c);

            int num = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (num > a)
                {
                    temp = a;
                    a = rnd.Next(temp, c);
                    Console.WriteLine(a);
                }
                else if (num < a)
                {

                    temp = a;
                    a = rnd.Next(b, temp);
                    Console.WriteLine(a);
                }
                else if (num == a)
                {
                    Console.WriteLine(a);
                }
            } while (num != a);
        }
    }
}
