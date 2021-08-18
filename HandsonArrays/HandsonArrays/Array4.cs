using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonArrays
{
    class Array4
    {
        static void Main()
        {
            //2 d array
            int[,] twod = new int[3, 2];
            //assign values
            //1st row
            twod[0, 0] = 10;
            twod[0, 1] = 20;
            //2nd row
            twod[1, 0] = 35;
            twod[1, 1] = 24;
            //3nd row
            twod[2, 0] = 89;
            twod[2, 1] = 56;
            //access values
            int k = twod[1, 0];//35
            foreach(int i in twod)
                Console.WriteLine(i);
            Console.WriteLine();
            //display elements in matrix
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.WriteLine(twod[i, j] + "\t");
                }
                Console.WriteLine();
            }
            

        }
    }
}
