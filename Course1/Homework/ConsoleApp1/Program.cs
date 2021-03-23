using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 1. 
            int[] array;
            // array = {0, 2, 4, 6};  -> error: missing 'new'
            array = new int[] { 0, 2, 4, 6 }; // the correct way to declare it 

            //Ex 2.
            int[] array2;
            //System.Console.WriteLine(array2[0]);  //  Use of unassigned local variable 'array2' -> not initialized

            //Ex 3.
            int[] array3 = new int[3];
            //  System.Console.WriteLine(array3[3]);//Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
            //

            //Ex4.
            //int[] array4 = new int[]; //missing array size 

            //Ex5.
            //int[] array5 = new int[3] { 0, 1, 2, 3};  //it should have only 3 elements

            //Decision making: Ex1.
            int number;
            //if number %2 == 0  //missing parentheses  -> if(number %2 == 0) {}

            // Ex2.
            int age;
            // if (age < 0) || (age > 100) //missing parentheses -> if((age < 0) || (age > 100)) {}

            //Ex 3.
            int minute = 5;
            /* if (minute == 60);  // ";" if body it's not executed 
                 minute = 0;*/

            //Loops: Ex 1.
            /*for (int i = 0, i< 10, i++)  // instead of: ',' it should be: ';'
                Console.Write(i);*/

            //Ex 2.
            //int i = 0;
            /*while (i < 10)
                Console.Write(i); //infinite loop because i it's not being increased*/

            //Ex 3.
            /*  for (int i = 0; i >= 10; i++)  //i can't be >= 10
                  Console.Write(i);  */

            //Ex 4.

           /* do {
                string line = Console.ReadLine();
                guess = int.Parse(line);
            } while(guess != answer);
           */

            //-> guess, answer are not initialized

            //The correct code: 
            int answer = 5;
            int guess;
            do
            {
                string line = Console.ReadLine();
                guess = int.Parse(line);
            } while (guess != answer);

            Console.WriteLine("Hello World!");
        }
    }
}
