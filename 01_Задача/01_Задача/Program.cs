using System;

namespace _01_Задача
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Превърнете числото 2086 в 2, 8 и 16 ична");
            
            int[] bases = { 2, 8, 10, 16 };
            int[] numbers = { 2086 };

            foreach (int baseValue in bases)
            {
                Console.WriteLine("Base {0} conversion:", baseValue);
                foreach (int number in numbers)
                {
                    Console.WriteLine("   {0,-15}  -->  0x{1}", number, Convert.ToString(number, baseValue));
                }
            }
        }
    }
}