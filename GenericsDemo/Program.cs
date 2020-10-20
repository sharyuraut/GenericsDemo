using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics code.");

            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.1, 3.1, 3.4 };
            char[] charArray = { 'h', 'r', 't' };

            Program.toPrint<int>(intArray);
            Program.toPrint<double>(doubleArray);
            Program.toPrint<char>(charArray);
        }

        private static void toPrint<T>(T[] intArray)
        {
            foreach (var element in intArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------");
        }
    }
}
