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

            Program.toPrint(intArray);
            Program.toPrint(doubleArray);
            Program.toPrint(charArray);
        }

        private static void toPrint(char[] charArray)
        {
            foreach(char element in charArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------");
        }

        private static void toPrint(double[] doubleArray)
        {
            foreach (double element in doubleArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------");
        }

        private static void toPrint(int[] intArray)
        {
            foreach (int element in intArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------");
        }
    }
}
