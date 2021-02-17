using System;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 5, 3, 9, 6, 4, 1 };
            int[] newArray = (int[])array.Clone();
            

            for (int i = 0; i < newArray.Length; i++)
            {
                if(newArray[i] == 9)
                {
                    newArray[i] = 5;
                }
            }

            newArray = Array.FindAll(newArray, removeQuatro);

            //printando array oiginal
            foreach (int i in array)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\n");

            //printando novo array
            foreach (int i in newArray)
            {
                Console.Write("{0} ", i);
            }
        }

        static bool removeQuatro(int n)
        {
            return n != 4;
        }
    }
}
