using System;

namespace homework008
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int howManyTimes;
            Console.Write("Введите текст: ");
            text = Convert.ToString(Console.ReadLine());
            Console.Write("Количество повторов: ");
            howManyTimes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < howManyTimes; i++)
            {
                Console.WriteLine(text);
            }
        }
        }       
    }
}