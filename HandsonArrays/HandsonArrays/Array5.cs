using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonArrays
{
    class Array5
    {
        static void Main()
        {
            int[][] ja = new int[3][];//3 indicated 3 different arrays
            ja[0] = new int[4] { 12, 23, 34, 45 };
            ja[1] = new int[2] { 56, 67 };
            ja[2] = new int[3] { 67, 78, 89 };
            int m = ja[0][0];
            for(int i=0;i<3;i++)
            {
                foreach(int k in ja[i])
                {
                    Console.Write(k + "\t");
                }
                Console.WriteLine();
            }
            int[,][] twodja = new int[1, 1][];
            twodja[0,0] = new int[2] { 2, 2 };
            twodja[0, 1] = new int[2] { 5, 6 };
        }
    }
}
