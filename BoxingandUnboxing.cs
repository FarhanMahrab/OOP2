using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingandUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*sbyte userValue = sbyte.Parse(Console.ReadLine());
            Console.WriteLine(userValue);

            int data = 128;
            byte a = Convert.ToByte(data);
            Console.WriteLine(a);

            double value1 = 100; //Boxed value
            object value2 = value1;//Unboxing: cast obj back to
            Console.WriteLine(value2);// Output: 100

            object obj = 123;          // Boxed value
            int num = (int)obj;        // Unboxing: cast obj back to int
            Console.WriteLine(num); */   // Output: 123

            String name;
            name = Console.ReadLine();
            Console.WriteLine("Hello World, My name is: "+ name);
            Console.WriteLine("One of my friends name is also {0}. His brothers name is also {1}", name, name);
            Console.WriteLine($"His fathers name is also: {name}");


        }
    }
}
