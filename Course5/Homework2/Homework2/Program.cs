using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exchange<int> array = new Exchange<int>();

            int[] arr = { 1, 5, 3, 7, 4, 6 };

            array.Swap(arr,  1, 3);
            array.PrintArray(arr);

        }
    }
}
