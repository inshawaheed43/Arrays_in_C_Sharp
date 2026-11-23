using System;
using System.Collections.Generic;
using System.Text;

namespace Arraysinc
{
    internal class TypesofArray
    {

        internal void tpofArr()
        {

            //OK SO THIS IS TWO -DIMENSIONAL ARRAY. BY [,] WE CAN SAY THAT'S 
            // TWO-DIMENSIONAL AND FOR 3 DIMENSIONAL WE'LL USE [,,]
            //int[,] num = { { 1, 2, 3 }, { 4, 5, 6 } };
            //Console.WriteLine(num[0,2]);


            // |         |  COLUMN 1 |  COLUMN 2  | COLUMN 3  |
            // | ROW 1   |      1    |     2      |     3     |     
            // | ROW 2   |      4    |     5      |     6     |  

            // SO THAT'S HOW WE CAN DEMONSTRATE OUR 2 DIMENSIONAL ARRAYS

            int[,] num = new int[3, 5]
            {
                { 2, 3,4,5,6},
                { 4,3,2,5,6},
                { 2,3,4,5,6}
            };

            Console.WriteLine(num[2, 2]);


        }
    }
}
