using System;
using System.Collections.Generic;
using System.Text;

namespace Arraysinc
{
    internal class restartProgram
    {

        internal void resProgram()
        {
            string confirm;
            do
            {
                Console.WriteLine("Enter first number");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int num1 = int.Parse(Console.ReadLine());
                int add = num + num1;
                Console.WriteLine("Adding: " + add);
                Console.WriteLine("Do you want to repeat your program?");
                confirm = Console.ReadLine();



            }
            while (confirm == "yes");

            Console.WriteLine("Program done!");


            Console.ReadLine();

        }
    }
}
