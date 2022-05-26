using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 43, 53, 66, 12 };
            int number = 5;
            array = AddToArray(ref array, number);
         //Burda yoxlamaq ucun console a yazdiriram arrayi onemi yoxdu ama
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
        //Burda arraya elave eleyirem reqemi 
        static int[] AddToArray(ref int[] arry, int n)
        {
            int[] numbers = new int[arry.Length + 1];
            for (int i = 0; i < arry.Length; i++)
            {
                numbers[i] += arry[i];
            }
            numbers[numbers.Length - 1] += n;
            arry = numbers;
            return arry;
        }
        
    }
}
