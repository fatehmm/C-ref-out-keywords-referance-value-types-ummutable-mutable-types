using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -13;
            PositiveInteger(ref a);
            Console.WriteLine(a);
        }
        /*Qəbul etdiyi ədədi musbətə ceviren metod*/
        static int PositiveInteger(ref int n)
        {
            int newNumber;
            if (n>=0)
            {
                newNumber = n;
            }
            else
            {
                newNumber = n * (-1);
            }
            n = newNumber;
            return n;
        }



    }
}
