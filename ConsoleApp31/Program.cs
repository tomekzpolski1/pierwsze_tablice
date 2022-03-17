using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            //pierwszy sposob
            int[] array = new int[5]; //deklaracja ablicy 5 "szuflad"
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            //Console.WriteLine(array[0]);
            Console.WriteLine("Lenght : {0}", array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            //drugi sposob
            char[] array2 = { 'H', 'e', 'l', 'l', 'o' };
            foreach (char item in array2) //jaki typ zmiennych do iteracji (char), item - tak ma sie nazywac, array2 - w czym mamy iterować
            {
                Console.WriteLine(item);
            }
        }
    }

}
