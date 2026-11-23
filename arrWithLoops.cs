
using System;
using System.Collections.Generic;
using System.Text;

namespace Arraysinc
{
    internal class arrWithLoops
    {

        internal void arrWLoop()
        {
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]); 
            }

            foreach (var n in numbers)
            {
                Console.WriteLine(n);

            }

        }
    }
}
