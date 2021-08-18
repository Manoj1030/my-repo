using System;

namespace HandsonArrays
{
    class Array
    {
        static void Main(string[] args)
        {
            //declare array
            int[] n = new int[5];
            //assign values
            n[0] = 45;
            n[1] = 23;
            n[2] = 89;
            n[3] = 5;
            n[4] = 4;
            //n[5]=99;exception or runtime error
            //access values
            int k = n[2];
            Console.WriteLine(n[2]);
            //access all values using for
            //for(int i=0;i<5;i++)
            //{
            //  Console.WriteLine(n[i]);
            //}
            foreach(int i in n)
            {
                Console.WriteLine(i);
            }
        }
    }
}
