using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 34, -56, 33, -1, -90, 31 };
            PositiveArray(ref numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        /*Qəbul etdiyi ədədlər siyahısının içərisindəki 
         * bütün ədədləri müsbət hala gətirən metod*/
        static int[] PositiveArray(ref int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>=0)
                {
                    newArray[i] += array[i];
                }
                else
                {
                    newArray[i] += array[i] * (-1);
                }
            }
            array = newArray;
            return array;
        }



    }
}
