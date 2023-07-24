using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i, j, n,s;
            //Console.WriteLine("enter the design pattern number : ");
            //n = Convert.ToInt32(Console.ReadLine());

            //square pattern design
            /*for (i = 0; i < n; i++)
            {
                for(j = 0; j < n;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            */

            //right triangle design
            /*for (i = 0; i < n; i++)
            {
                for (j = 0; j < i+1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }*/

            //invered half pyramid
            /*for (i = 0; i < n; i++)
            {
                for (j = 0; j < n-i; j++)
                {
                    Console.Write(,j+1);
                }
                Console.WriteLine("");
            }*/

            //Hollow square pattern
            /*for(i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    if((i==0) || (i==n-1) || (j==0) || (j == n - 1)) 
                    {
                        Console.Write("* ");
                    }else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }*/

            //pyramid pattern
            //method 1
            /* for(i = 0; i < n; i++)
             {
                 for(s = 0; s < n-i-1;s++)
                     Console.Write("  ");
                 for(j = 0; j < i*2+1;j++)
                     Console.Write("* ");
                 Console.WriteLine();
             }*/

            //methode 2
            /* for(i= 0; i < n; i++)
              {
                  for(j = 0; j < n+i;j++)
                  {
                      if(j < n - i - 1)
                      {
                          Console.Write("  ");
                      }
                      else
                      {
                          Console.Write("* ");
                      }
                  }
                  Console.WriteLine();
              }*/

            //
            /*for (i = 2; i <= 4; i++) //1 2 3
            {
                for (j = 3; j <= 5; j++) //1 2
                { 
                    Console.WriteLine("i="+i);
                    Console.WriteLine("j=" + j);
                }
            }*/

            int i = 1 ;
            while (i <= 4)
            {
                int j = 3;
                while (j<=6)
                {
                    Console.WriteLine(i*j);
                    j++;
                }
                i++;
            }

            Console.ReadKey();
        }
    }
}
