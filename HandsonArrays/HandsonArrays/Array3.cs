using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonArrays
{
    class Array3
    {
        static void Main()
        {
            int[] n = new int[3];
            //read array
            for(int i=0;i<n.Length;i++)
            {
                Console.WriteLine("n{0}", i);
                n[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            foreach(int k in n)
            {
                Console.Write(k + "\t");
            }
        }
    }
}
