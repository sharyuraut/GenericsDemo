using System;

namespace GenericsDemo
{
    public class PrintArray<T>
    {
        private T[] inputArray;
        public PrintArray(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void toPrint()
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics code.");

            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.1, 3.1, 3.4 };
            char[] charArray = { 'h', 'r', 't' };

            new PrintArray<int>(intArray).toPrint();
            new PrintArray<double>(doubleArray).toPrint();
            new PrintArray<char>(charArray).toPrint();
        }
    }
}
