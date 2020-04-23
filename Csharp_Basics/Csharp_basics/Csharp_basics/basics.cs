using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_basics
{
    class basics
    {
        /* pass by value (value never changed)*/
        static void Main()
        {
            int[] ar = new int[3];
            sam_params(ar); //passing array as parameter
            sam_params(1, 2, 4, 5, 8);//passing array of numbers as parameters
            /*int add = 0;
            int mul = 0;
            calc(10, 20, out add, out mul);
            Console.WriteLine("sum is {0} and prod is {1}", add, mul);
            /*int i = 1;
            sam(i);
            Console.WriteLine("i is {0}", i);
            sam_ref(ref i);
            Console.WriteLine("ref i is {0}", i);  //i value will be changed to j value due to ref*/ 

        }
        /*static void sam(int j)
        {
            j = 101;
            Console.WriteLine("j is {0}", j);
        }
        /* pass by ref */
        /*static void sam_ref(ref int j)
        {
            j = 101;
            Console.WriteLine("j is {0}", j);
        }*/
        /*static void calc(int a,int b,out int sum,out int prod)
        {
            sum = a + b;
            prod = a * b;
        }*/
        /*parameter arrays */
        static void sam_params(params int[] elm)
        {
            foreach (int itr in elm)
                Console.WriteLine(itr);

        }
    }
    
}
