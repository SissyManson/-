using System;

namespace _03_Задача
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("48 зад. a)\nЗапишете като фрагмент от програма следната функция:\ny=5x+1 за x<=0 и y=1-x за x>0");
            Console.Write("\nx=");
            int x = int.Parse(Console.ReadLine());
            double y = 5 * x + 1;
            if (x > 0) y = 1 - x;
            Console.WriteLine("y= {0}",y);
            
        }
    }
}
