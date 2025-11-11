using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String Input
            Console.Write("Enter a string: ");
            string strInput = Console.ReadLine();
            Console.WriteLine("You entered the string: " + strInput);

            // Integer Input
            Console.Write("Enter an integer: ");
            int intInput = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered the integer: " + intInput);

            // Double (floating-point) Input
            Console.Write("Enter a double: ");
            double doubleInput = double.Parse(Console.ReadLine());
            Console.WriteLine("You entered the double: " + doubleInput);

            // Boolean Input
            Console.Write("Enter a boolean (true/false): ");
            bool boolInput = bool.Parse(Console.ReadLine());
            Console.WriteLine("You entered the boolean: " + boolInput);

            // Character Input
            Console.Write("Enter a character: ");
            char charInput = Console.ReadLine()[0];
            Console.WriteLine("You entered the character: " + charInput);

            // Float Input
            Console.Write("Enter a float: ");
            float floatInput = float.Parse(Console.ReadLine());
            Console.WriteLine("You entered the float: " + floatInput);

            // Decimal Input
            Console.Write("Enter a decimal: ");
            decimal decimalInput = decimal.Parse(Console.ReadLine());
            Console.WriteLine("You entered the decimal: " + decimalInput);

            // Byte Input
            Console.Write("Enter a byte (0-255): ");
            byte byteInput = byte.Parse(Console.ReadLine());
            Console.WriteLine("You entered the byte: " + byteInput);

            // SByte Input (Signed Byte)
            Console.Write("Enter an sbyte (-128 to 127): ");
            sbyte sbyteInput = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("You entered the sbyte: " + sbyteInput);

            // Short Input
            Console.Write("Enter a short integer (-32,768 to 32,767): ");
            short shortInput = short.Parse(Console.ReadLine());
            Console.WriteLine("You entered the short: " + shortInput);

            // Unsigned Integer Input
            Console.Write("Enter an unsigned integer (0 to 4,294,967,295): ");
            uint uintInput = uint.Parse(Console.ReadLine());
            Console.WriteLine("You entered the unsigned integer: " + uintInput);

            // Long Input
            Console.Write("Enter a long integer: ");
            long longInput = long.Parse(Console.ReadLine());
            Console.WriteLine("You entered the long integer: " + longInput);

            // Unsigned Long Input
            Console.Write("Enter an unsigned long integer: ");
            ulong ulongInput = ulong.Parse(Console.ReadLine());
            Console.WriteLine("You entered the unsigned long integer: " + ulongInput);
        }
    }
}
