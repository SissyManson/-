using System;

namespace _02_Задача //Тест 1 - 7 I)
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тест 1 - 7 I)");
            Console.WriteLine("Програма, която изчислява и извежда обема V на пресечен конус, като се зададат H,R,r.");
            Console.Write("Въведете H:");
            int H = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете R:");
            int R = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете r:");
            int r = Int32.Parse(Console.ReadLine());
            Console.Write("Обема на пресечения конус е V= {0}.\n",Math.PI*H*(R*R+R*r+r*r)/3);

        }
    }
}
