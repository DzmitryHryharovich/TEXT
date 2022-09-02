using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Text.NumbersToWords.Number(int.Parse(Console.ReadLine())));
            Main();
        }
    }
}
