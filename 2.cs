using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Kelbiyev Musayeddin Ramazan oglu";
            name = StringArranger(ref name);
            Console.WriteLine(name);
        }
        /*Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri əvvəlində 
         * və sonunda boşluqlar qalmayacaq hala gətirən metod.
         * Misal olaraq, name = " Hikmet  Abbasov " deyə bir variable-mız varsa onu 
         * yaratdigimiz metoda göndərdikdə variable-daki dəyər "HikmətAbbasov" olmalıdır.*/
        static string StringArranger(ref string stringName)
        {
            string bosluqStr = " ";
            char bosluq = Convert.ToChar(bosluqStr);

            string newStringName = "";
            for (int i = 0; i < stringName.Length; i++)
            {
                if (stringName[i]!=bosluq)
                {
                    newStringName += stringName[i];
                }
            }

            stringName = newStringName;
            return stringName;
        }



    }
}
