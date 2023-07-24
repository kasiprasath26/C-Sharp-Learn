using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace register
{
    internal class array
    {
        static void printarray(int[] arr)
        {
            Console.WriteLine("enter the array number");
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
                
        }
    }
}
