using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Services;

namespace register
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("enter the first number ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            
            if (a > b)
            {
                Console.WriteLine("a is greater");
            }
            else {
                Console.WriteLine("b is greater");
                    }
            Console.ReadKey();
            */

            /* even & odd number find the program
            Console.WriteLine("enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Even number " + n);
            }
            else
                Console.WriteLine("Odd number " + n);
            Console.ReadKey();
            */

            /*
            Console.WriteLine("enter the first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number : ");
            int num2  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            
            int average;

            average = (num1 + num2 + num3) / 3;
            Console.WriteLine("Average of total number : " + average);
            Console.ReadKey();
            */

            /*
            int num;
            Console.WriteLine("chechk whether positive or negative number : ");
            Console.WriteLine("----------------------------------------------");
            Console.Write("enter the integer number : ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0) 
            {
                Console.WriteLine("The number is positive : " +  num);
            }
            else
            { 
                Console.WriteLine("The number is negative number : " + num);
            }
            Console.ReadKey();
            */

            /* leep year find out programme
            Console.WriteLine("enter the leep year");
            int year = Convert.ToInt32(Console.ReadLine());
            if((year % 4 == 0 )&&(year % 100 != 0)||(year % 400 == 0))
            {
                Console.WriteLine("this year will be leep year");
            }
            else {
                Console.WriteLine("this year not will be leep year");
                    }
            Console.ReadKey();

            //given number is 3 dividable
            Console.WriteLine("enter a given number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num % 3==0)
            { 
                Console.WriteLine("yes " + num);
            }else
                Console.WriteLine("no" + num);
            Console.ReadKey();

            //the give number is 100 above
            Console.WriteLine("enter the string ");
            string name = Console.ReadLine();   
            int l = name.Length;
            char c = name[l - 1];
            if(name.EndsWith("a")|| name.EndsWith("e") || name.EndsWith("i"))
            {
                Console.WriteLine("the last letter in string is vowel");
            }
            else
            {
                Console.WriteLine("the last letter in string is not vowel");
            } */

            /*
            //Given string in last letter is vowel or not
            Console.WriteLine("Enter the string :");
            string name = Console.ReadLine();
            int l = name.Length;
            char c = name[l - 1];
            if (name.EndsWith("a") || name.EndsWith("e") || name.EndsWith("i") 
                || name.EndsWith("o") || name.EndsWith("u")||
                name.EndsWith("A") || name.EndsWith("E") || name.EndsWith("I")
                || name.EndsWith("O") || name.EndsWith("U"))
            {
                Console.WriteLine("the last letter is vowels");
            }
            else
                Console.WriteLine("the last letter is not vowels");
            Console.ReadKey();
            */
            /*
            Console.WriteLine("find the maximimum number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("number one is big");
            }
            else if (n2 > n3 && n1 > n3)
            {
                Console.WriteLine("number two is big");
            }
            else
                Console.WriteLine("number three is big");
            Console.ReadKey();*/

            //find the minimum values
            /*int a, b, c, d, e;
            a= Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            if (a>b && a>c && a>d && a > e)
            {
                Console.WriteLine("maximum number is a : " + a);
            }
            else if(b>a && b>c && b>d && b>e)
            {
                Console.WriteLine("maximum number is b : " + b);
            }
            else if (c > a && c > b && c > d && c > e) 
            {
                Console.WriteLine("maximum number is c : " + c);
            }
            else if (d > a && d > b && d > c && d> e)
            {
                Console.WriteLine("maximum number is d : " + d);
            }
            else if (e > a && e > b && e > c && e > d)
            {
                Console.WriteLine("maximum number is e : " + e);
            }*/
            /*
                        //find the odd number 60-30
                        Console.WriteLine("enter the number  upto 30 -60");
                        for (int i = 60; i >= 30; i--)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }


                       //square number upto 1 to 5
                        Console.WriteLine("enter the number");
                        int number = Convert.ToInt32(Console.ReadLine());
                        int store;
                            for (int i = 1; i <= 5; i++)
                            {
                                store = number * number;
                                Console.WriteLine(store);
                            }


                        //print sum of number 1-10
                        int sum =0;
                        for(int i=1;i<=10;i++)
                        {
                            sum = i + sum;

                        }
                        Console.WriteLine(sum);*/

            /*Console.WriteLine("enter the name : ");
            string name;
            name = Console.ReadLine();
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(name);
                i++;
            }*/
            // you have 3 attempt get the user , if it is even
            //then print it otherwise get the number
            //untill even number

            /*  int j =1;
              int num;
              while (j <= 3)
              {   
                  Console.WriteLine("enter the number :");
                  num = Convert.ToInt32(Console.ReadLine());
                  if (num % 2 == 0) {
                      Console.WriteLine("even number");
                      break;
                  }
                  else
                  {
                      Console.WriteLine("not even number");
                  }
                  j++;
              }*/

            /*Console.WriteLine("enter the name :");
            string name = Console.ReadLine();
            
            if (name.StartsWith("s"))
            {
                int i = 1;
                while (i <= 3)
                {
                    Console.WriteLine("start with s");
                    i++;
                }

            }*/
            /*Console.WriteLine("enter your age :");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("adult ticket");
            }
            else
                Console.WriteLine("child tickert");
*/
            /*Console.WriteLine("enter the age :");
            int a = Convert.ToInt32(Console.ReadLine());
            string total = (a > 18) ? "age is 18 above " : "age is below 18 ";
            Console.WriteLine(total);*/

            /*int day = Convert.ToInt32(Console.ReadLine());
            switch(day)
            { 
                case 0:
                    Console.WriteLine("sunday");
                    break;
                case 1: Console.WriteLine("monday"); break;
                case 2: Console.WriteLine("tuesday"); break;
                case 3: Console.WriteLine("wednesday"); break;
                case 4: Console.WriteLine("thursday"); break;
                case 5: Console.WriteLine("friday"); break;
                case 6: Console.WriteLine("saturday"); break;
                default:
                    Console.WriteLine("please check your number");
                    break;
            }*/

            //find the factorial 
            /*int n = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for(int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);*/

            /*string[] cars = { "adi", "volvo", "bnw" };
            cars[0] = "bensc";
            for(int i= 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i ]);
            }*/
            //fibnasid series
            /*int n = Convert.ToInt32(Console.ReadLine());
            int a = -1, b = 1, c;
            for(int i = 1; i <= n;i++)
            {
                c = a + b;
                Console.WriteLine(c);   
                a = b; b = c;
            }*/
            /* int[] arr = new int[6] { 10, 20, 30, 40, 50, 60 };
             Console.WriteLine(arr[5]);*/
            /*int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[2]);*/

            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4,5,6,7 };
            array a = new array();
           a.printarray(arr1 );



            Console.ReadKey();
        }   
    }
}
