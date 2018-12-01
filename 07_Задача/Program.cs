using System;
using System.IO;
using System.Linq;

namespace _07_Задача
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("358 зад. Съставете програма, в която да се въвеждат произволен брой имена\nразделени с точно 1 интервал, а се извеждат инициалите на първите 2 имена и последното име.\nНапример, въвежда се Абу Джафар Мохамед ибн Муса ал-Хорезми,\nа се извежда А.Д. ал-Хорезми.\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Въведете вашите имена: ");
            string name = Console.ReadLine();
            Console.ResetColor();


            //      Get first character

            string first = name.Substring(0, 1);
            //Console.WriteLine("Substring: {0}.", first);


            //      Get First character after the space

            string second = name.Substring(name.IndexOf(" ")+1, 1);
            //Console.WriteLine("s2: "+second);


            //      Get last name

            string[] words = name.Split(' ');
            string last = words[words.Length - 1];
            //Console.WriteLine(last);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nИзвеждат се инициалите на първите 2 имена и последното име:\n{0}. {1}. {2}", first, second, last);
            Console.ResetColor();
        }
    }
}