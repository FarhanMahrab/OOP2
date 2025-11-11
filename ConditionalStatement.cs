using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatement
{
    internal class Program
    {
        static void Main(String[] arg)
        {
            int number;
            number = int.Parse(Console.ReadLine());
            if (number < 10)
            {
                Console.WriteLine("The number is less than 10.");
            }
            else if (number == 10)
            {
                Console.WriteLine("The number is exactly 10.");
            }
            else
            {
                Console.WriteLine("The number is greater than 10.");
            }
        }
    }
}
