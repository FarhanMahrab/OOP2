using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Postfix increment operator

            int i = 3;
            Console.WriteLine(i);
            Console.WriteLine(i++);
            Console.WriteLine(i);

            //Prefix increment operator

            double a = 1.5;
            Console.WriteLine(a);
            Console.WriteLine(++a);
            Console.WriteLine(a);

            //Postfix decrement operator

            int j = 3;
            Console.WriteLine(j);
            Console.WriteLine(j--);
            Console.WriteLine(j);

            //Prefix decrement operator
            double b = 1.5;
            Console.WriteLine(b);
            Console.WriteLine(--b);
            Console.WriteLine(b);

            //Addition operator
            Console.WriteLine(5 + 4); 
            Console.WriteLine(5 + 4.3);
            Console.WriteLine(5.1m + 4.2m);

            //Subtraction operator
            Console.WriteLine(47 - 3);      // output: 44
            Console.WriteLine(5 - 4.3);     // output: 0.7
            Console.WriteLine(7.5m - 2.3m); // output: 5.2

            //Multiplication operator
            Console.WriteLine(5 * 2);
            Console.WriteLine(0.5 * 2.5);
            Console.WriteLine(0.1m * 23.4m);

            //Division operator: Integer division

            Console.WriteLine(13 / 5);
            Console.WriteLine(-13 / 5);
            Console.WriteLine(13 / -5);
            Console.WriteLine(-13 / -5);

            // Division operator: Integer division

            Console.WriteLine(13 / 5.0);

            int c = 13;
            int d = 5;
            Console.WriteLine((double)c / d);

            //Floating-point division
            Console.WriteLine(16.8f / 4.1f);
            Console.WriteLine(16.8d / 4.1d);
            Console.WriteLine(16.8m / 4.1m);

            //Remainder operator: Integer remainder

            Console.WriteLine(5 % 4);
            Console.WriteLine(5 % -4);
            Console.WriteLine(-5 % 4);
            Console.WriteLine(-5 % -4);

            Console.WriteLine(-5.2f % 2.0f);
            Console.WriteLine(5.9 % 3.1);
            Console.WriteLine(5.9m % 3.1m);

            //Compound Assignment

            int e = 5;
            e += 9;
            Console.WriteLine(e);  // output: 14

            e -= 4;
            Console.WriteLine(e);  // output: 10

            e *= 2;
            Console.WriteLine(e);  // output: 20

            e /= 4;
            Console.WriteLine(e);  // output: 5

            e %= 3;
            Console.WriteLine(e);  // output: 2*/
            //Practice
            int a1, b1, c1;
            a1 = 7;
            Console.WriteLine("Value of a1:" +a1);
            b1 = a1;
            Console.WriteLine("Value of b1:" +b1);
            c1 = b1++;
            Console.WriteLine("Value of c1:" + c1);
            b1 = a1 + b1 * c1;
            Console.WriteLine("Updated value of b1: "+b1);
            c1 = a1 >= 100 ? b1 : c1 / 10;
            Console.WriteLine("uPDATED VALUE OF C1: "+c1);
            a1 = (int)Math.Sqrt(b1 * b1 + c1 * c1);
            Console.WriteLine(a1);


        }
    }
}
