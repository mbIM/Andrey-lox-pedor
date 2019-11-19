using System;

namespace iluxa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(69, 1265);

            Console.WriteLine(a);
        }
    }
}
