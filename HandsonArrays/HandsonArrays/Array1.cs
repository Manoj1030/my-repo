using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonArrays
{
    class Array1
    {
        static void Main()
        {
            int[] n = new int[4] { 2, 3, 4, 5 };
            char[] ch = new char[4] { 'a', 'b', 'c', 'v' };
            double[] prices = new double[3]
            {
                23.23,
                34.34,
                45.45
            };
            string[] flower = new string[3]
            {
                "Rose",
                "Sunflowers",
                "lily"

            };
            foreach (string s in flower)
            {
                if (s.Length > 4)
                    Console.WriteLine(s);
            }
        }
    }
}
