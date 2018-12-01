using System;

namespace _06_Задача //413 зад.
{
    class Program
    {
        static void Input(double[] a)
        {
            for (int i = 0;  i < a.Length; i++)
            {
                Console.Write("a["+i+"]= ");
                a[i] = double.Parse(Console.ReadLine());
            }
        }

        static double Avg(double[] a)
        {
            double sum = 0;
            double d = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (i%3==0) //chiito indexi se delqt na 3 bez otatak
                {
                    sum += a[i];
                    d++;
                }
            }
            return sum / d;
        }

        static void Main()
        {
            Console.WriteLine("413 зад.2 метода: за въвеждане на едномерен масив от цели числа");
            Console.WriteLine(" и за изчисляване на средноаритметичното на тези елементи, на масива, чиито индекси се делят на 3 без остатък");
            Console.Write("\nВъведете брой елементи на масива: ");
            int t = int.Parse(Console.ReadLine());
            double[] a = new double [t];
            Input(a);
            Console.WriteLine("Средноаритметичното на тези елементи на масива, чиито индекси се делят на 3 без остатък е: "+Avg(a));
            Console.ReadKey(true);

            Console.WriteLine("\nВъвете цяло число N (броя на елементите в масива):");
            int n = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nВъведете {0} елемента в първия масив:",n);
            Console.ResetColor();
            double[] A = new double[n];
            Input(A);
            Console.WriteLine("Средноаритметичното на тези елементи на Първи масив, чиито индекси се делят на 3 без остатък е: " + Avg(A));
            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nВъведете {0} елемента във втория масив:", n);
            Console.ResetColor();
            double[] B = new double[n];
            Input(B);
            Console.WriteLine("Средноаритметичното на тези елементи на Втори масив, чиито индекси се делят на 3 без остатък е: " + Avg(B));
            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("/nВъведете {0} елемента в третия масив:", n);
            Console.ResetColor();
            double[] C = new double[n];
            Input(C);
            Console.WriteLine("Средноаритметичното на тези елементи на Трети масив, чиито индекси се делят на 3 без остатък е: " + Avg(C));
            Console.ReadKey(true);

            double masAC = Avg(A) + Avg(B) + Avg(C);
            Console.WriteLine("Средно квадратичното на последните 3 масива е: {0}",Math.Sqrt(masAC));
        }

    }
}
