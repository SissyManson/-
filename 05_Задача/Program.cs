using System;

namespace _05_Задача //379-Не е изцяло готова. Да се намери и отпечата Sss(|c-b|)*Sss(a+c)
{
    class Program
    {
        static void Sss (int k)
        {
            Random rand = new Random();
            for (int i = 1; i <= k; i++)
            {
                 int x = rand.Next(150);
                //Console.WriteLine("" + x);
                if (x % 10 != 5 && (x <= 10 || x >= 99))
                {
                    Console.WriteLine("Произведението на тези от тях, които са двуцифрени и завършват на 5: {0}", x *= x);
                }else Console.WriteLine("Няма такива числа.");
            }
           // return x *= x; //if it was int
        }
        static void Main(string[] args)
        {
            Console.WriteLine("379 зад.\nДа се генерира редица от 132 случайни цели числа принадлежащи на интервала [0;150].");
            Random rand = new Random();

            Console.WriteLine("Нечетни числа:");
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 1; i <= 132; i++)
            {
                int x = rand.Next(0, 150);
                if (x % 2 != 0)
                {
                    Console.WriteLine(""+ x);
                }
            }
            Console.ResetColor();

            Console.WriteLine("Въведете 5 цели положителни числа:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            int number5 = int.Parse(Console.ReadLine());
            double sum = number1 * number2 * number3 * number4 * number5;
            Console.WriteLine("Средно геометричното на числата е: {0}", Math.Pow(Math.Sqrt(sum), 5));

            Console.WriteLine("Колко случайни числа искате? ");
            int k = int.Parse(Console.ReadLine());
            //тъй като генерира к случайни числа, и трябва да изведе произв.на двуц.,завършващи на 5, ограничих диапазона до макс 150
            //понякога това може да е празно
            Sss(k);

            //Console.Write("Въведете а= ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("\nВъведете b= ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("\nВъведете c= ");
            //int c = int.Parse(Console.ReadLine());
            //Console.WriteLine("",Sss();
        }
    }
}
