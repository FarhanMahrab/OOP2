using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Integer Types
            int myInt = 123;
            long myLong = -123456789L;
            short myShort = 32000;
            byte myByte = 255;

            // Floating-Point Types
            float myFloat = 3.14F;
            double myDouble = 3.141592653;
            decimal myDecimal = 19.99M;

            // Character and String Types
            char myChar = 'A';
            string myString = "Hello World";

            // Boolean Type
            bool myBool = true;
            bool isRaining = false;

            // DateTime Type
            DateTime currentDate = DateTime.Now;
            DateTime specificDate = new DateTime(2024, 10, 23);

            // Object Type
            object myObject = "This is a string";
            myObject = 123;

            // Nullable Type
            int? nullableInt = null;
            nullableInt = 10;

            // Array Types
            int[] myIntArray = { 1, 2, 3, 4, 5 };
            string[] myStringArray = { "one", "two", "three" };

            // Dynamic Type
            dynamic myDynamic = 100;
            myDynamic = "Hello";

            // Printing all variables
            Console.WriteLine("Integer Types:");
            Console.WriteLine("int: " + myInt);
            Console.WriteLine("long: " + myLong);
            Console.WriteLine("short: " + myShort);
            Console.WriteLine("byte: " + myByte);

            Console.WriteLine("\nFloating-Point Types:");
            Console.WriteLine("float: " + myFloat);
            Console.WriteLine("double: " + myDouble);
            Console.WriteLine("decimal: " + myDecimal);

            Console.WriteLine("\nCharacter and String Types:");
            Console.WriteLine("char: " + myChar);
            Console.WriteLine("string: " + myString);

            Console.WriteLine("\nBoolean Types:");
            Console.WriteLine("bool (myBool): " + myBool);
            Console.WriteLine("bool (isRaining): " + isRaining);

            Console.WriteLine("\nDateTime Type:");
            Console.WriteLine("Current Date and Time: " + currentDate);
            Console.WriteLine("Specific Date: " + specificDate);

            Console.WriteLine("\nObject Type:");
            Console.WriteLine("object: " + myObject);

            Console.WriteLine("\nNullable Type:");
            Console.WriteLine("nullableInt: " + nullableInt);

            Console.WriteLine("\nArray Types:");
            Console.WriteLine("Integer Array: " + string.Join(", ", myIntArray));
            Console.WriteLine("String Array: " + string.Join(", ", myStringArray));

            Console.WriteLine("\nDynamic Type:");
            Console.WriteLine("dynamic: " + myDynamic);

            Console.ReadKey(); // Keeps the console window open
        }
    }
}
