using System;
using System.Collections.Generic;
using System.Text;

namespace Arraysinc
{
    internal class arrwithUser
    {
      internal void arrWUserInput()
        {
            Console.WriteLine("How many numbers do you want to save in array?");
            int num = int.Parse(Console.ReadLine());
            int[] numbers = new int[num];
            for (int i = 0; i < num ; i++)
            {

                Console.WriteLine("Enter Data:");
                int data = int.Parse(Console.ReadLine());
                numbers[i] = data;

            }

            Console.WriteLine("-------------------Your Data-----------------");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
