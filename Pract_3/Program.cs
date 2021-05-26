using System;
using System.Linq;

namespace Pract_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task_1
            int[] mass = new int[] { 10, -3, -5, 5, -10, 12, -42, -1 };
            int n = 0;
            int min;
            min = mass[0];
            for (int i = 1; i < mass.Length; i++)
            {
                if (mass[i] < min)
                    min = Math.Abs(mass[i]);
                n = n + 1;
            }
            Console.WriteLine(n);

            //Task_2
            int[] mass2 = new int[] { 10, -3, -5, -5, -10, 12, -42, -10 };


        }
    }
}
