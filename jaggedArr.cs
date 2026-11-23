using System;
using System.Collections.Generic;
using System.Text;

namespace Arraysinc
{
    internal class jaggedArr
    {
        internal void jagArr()
        {
            int[][] myArr = new int[3][];
            myArr[0] = new[] { 11, 2, 3, 2 };
            myArr[1] = new[] { 11, 2, 3, 2 };
            myArr[2] = new[] { 11, 2, 3, 2 };


            for (int i = 0; i < myArr.GetLength(0); i++)
            {
                for (int j = 0; j < myArr.GetLength(1); j++)
                {
                    Console.WriteLine(myArr[i][j] + " ");


                }


                foreach (int[] n in myArr)
                {
                    foreach (int item in n)
                    {
                        Console.WriteLine(item + " ");

                    }
                }
            }


        }
    }
}