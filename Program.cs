using System;
using System.Runtime.InteropServices;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] myNumbers = new int[5];

            Console.WriteLine("Enter the Numbers");

            for (int i = 0; i < myNumbers.Length; i++)
            { 

            myNumbers[i] = Convert.ToInt32(Console.ReadLine());

            }

            

            Array.Reverse(myNumbers);

            Console.WriteLine("The reverse order of the numbers is:");

            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }
        }
    }
}
