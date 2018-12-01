using System;

namespace _04_Задача //209 зад. г)
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("209 зад. г) \nДа се генерира редица от 100 случайни цели числа,принадлежащи на интервала [0;132].");
            Random rand = new Random();

            Console.WriteLine("г) Числата, които се делят на 7 с остатък 1:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int c = 1; c <= 100; c++)
            {
                int a = rand.Next(0, 132);
                if (a % 7 == 1)
                {
                    Console.WriteLine("N:" + c + "  x=" + a);
                }
            }
            Console.ResetColor();
        }
    }
}
