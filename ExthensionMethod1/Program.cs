using System;

namespace ExthensionMethod1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 10, 24, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}