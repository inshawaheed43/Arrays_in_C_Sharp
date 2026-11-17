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
            Console.WriteLine(myArray[2]);

        }
    }
}
