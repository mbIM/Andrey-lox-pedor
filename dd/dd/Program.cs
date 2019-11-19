using System;

namespace dd
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "Uchitel";
            string parol = "Krasava";

            string login1 = "";
            string parol1 = "";

            do
            {
                login1 = Console.ReadLine();
                parol1 = Console.ReadLine();

                if (login1 == login)
                {
                    Console.WriteLine("Правильный логин");
                }
                else if (login1 != login)
                {
                    Console.WriteLine("Неправильный логин");
                }

                if (parol1 == parol)
                {
                    Console.WriteLine("Вход разрешён");
                }
                else if (parol1 != parol)
                {
                    Console.WriteLine("Неправильный пароль");
                }
            } while (login1 != login && parol1 != parol);
        }
    }
}
