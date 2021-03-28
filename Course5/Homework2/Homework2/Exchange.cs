using System;

namespace Homework2
{
  public class Exchange<T>
    {

        public T[] Swap(T[] element, int firstIndex, int lastIndex)
        {

            var temp = element[firstIndex];
            element[firstIndex] = element[lastIndex];
            element[lastIndex] = temp;

            return element;
        }

          public void PrintArray(T[] element)
          {
            for (int i = 0; i < element.Length; i++)
                Console.WriteLine(element[i]);
          }
    }
}