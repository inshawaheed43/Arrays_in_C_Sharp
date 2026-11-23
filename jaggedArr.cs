using System;
using System.Collections.Generic;
using System.Text;

namespace Arraysinc
{
    internal class jaggedArr
    {
        internal void jagArr()
        {
            int[][] myArr = new int[3][] ;
            myArr[0] = new[] { 11, 2, 3, 2 }; 
            myArr[1] = new[] { 11, 2, 3, 2 };
            myArr[2] = new[] { 11, 2, 3, 2 };

            Console.WriteLine(myArr[2][3]);
        }
    }
}
