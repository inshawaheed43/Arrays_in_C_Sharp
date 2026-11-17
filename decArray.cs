using System;
using System.Collections.Generic;
using System.Text;

namespace Arraysinc
{
    internal class decArray
    {

        //IN ARRAY WE CAN ONLY STORE DATA OF SAME DATA TYPES, 
        // STORE IN ADJACENT MEMORY LOCATIONS
        //IT'S A COLLECTION OF RELATED VALUES
        internal void declareArray()
        {
            // IS ARRAY SYNTAX KE ANDR JUST HM 4 ITEMS SAVE KRWA SKTE HEIN 
            int[] myArray = new int[4];
            myArray[0] = 12;
            myArray[1] = 12;
            myArray[2] = 12;
            myArray[3] = 12;
            //Console.WriteLine(myArray[2]);



            //2NND WAY OF DECLARING AN ARRAY
            string[] myArray1 = new string[]{"Insha","noor", "Zara"};
            string[] myArray2 = { "Insha", "Noor", "Zara" };



            //WE CAN ALSO WORK WITH FOR LOOP + ARRAYS

            int[] numbers = new int[3];
            numbers[0] = 10;
            numbers[1] = 20;

            numbers[2] = 30;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                
            }


        }
    }
}
