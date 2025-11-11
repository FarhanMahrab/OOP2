
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Length: Shows the length of the original string.
                ToUpper & ToLower: Converts the string to uppercase and lowercase.
                Substring: Extracts a portion of the string.
                IndexOf: Finds the index of a substring.
                Contains: Checks if a substring is in the string
                Replace: Replaces a substring with another.
                Trim: Removes whitespace from the start and end.
                Split: Splits the string by spaces.
                Join: Joins an array of strings with a hyphen.
                StartsWith & EndsWith: Checks the beginning and end of the string.
                IsNullOrEmpty & IsNullOrWhiteSpace: Checks if a string is empty or only whitespace.
                Concat: Concatenates two strings.
                Format: Formats a string with placeholders.
             */
            // 1. Length
            string str = "  Hello World  ";
            Console.WriteLine("Original string: \"" + str + "\"");
            Console.WriteLine("Length: " + str.Length);

            // 2. ToUpper and ToLower
            Console.WriteLine("ToUpper: " + str.ToUpper());
            Console.WriteLine("ToLower: " + str.ToLower());

            // 3. Substring
            string subStr = str.Substring(3, 5);
            Console.WriteLine("Substring (3, 5): " + subStr);

            // 4. IndexOf
            int index = str.IndexOf("World");
            Console.WriteLine("IndexOf 'World': " + index);

            // 5. Contains
            bool containsHello = str.Contains("Hello");
            Console.WriteLine("Contains 'Hello': " + containsHello);

            // 6. Replace
            string replacedStr = str.Replace("World", "C#");
            Console.WriteLine("Replace 'World' with 'C#': " + replacedStr);

            // 7. Trim
            string trimmedStr = str.Trim();
            Console.WriteLine("Trimmed string: \"" + trimmedStr + "\"");

            // 8. Split
            string[] words = trimmedStr.Split(' ');
            Console.WriteLine("Split:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // 9. Join
            string joinedStr = string.Join("-", words);
            Console.WriteLine("Join with '-': " + joinedStr);

            // 10. StartsWith and EndsWith
            bool startsWithHello = trimmedStr.StartsWith("Hello");
            bool endsWithWorld = trimmedStr.EndsWith("World");
            Console.WriteLine("Starts with 'Hello': " + startsWithHello);
            Console.WriteLine("Ends with 'World': " + endsWithWorld);

            // 11. IsNullOrEmpty and IsNullOrWhiteSpace
            string emptyStr = "   ";
            Console.WriteLine("IsNullOrEmpty on empty string: " + string.IsNullOrEmpty(emptyStr));
            Console.WriteLine("IsNullOrWhiteSpace on empty string: " + string.IsNullOrWhiteSpace(emptyStr));

            // 12. Concat
            string str1 = "Hello";
            string str2 = "C#";
            string concatStr = string.Concat(str1, " ", str2);
            Console.WriteLine("Concat: " + concatStr);

            // 13. Format
            string name = "John";
            int age = 30;
            string formattedStr = string.Format("Name: {0}, Age: {1}", name, age);
            Console.WriteLine("Formatted string: " + formattedStr);
        }
    }
}
