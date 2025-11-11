using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number if row: ");
            int rows = int.Parse((Console.ReadLine()));

            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                Console.Write($"For row {i}, enter the number of elements: ");
                int columns = int.Parse((Console.ReadLine()));
                jaggedArray[i] = new int[columns];

                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    jaggedArray[i][j] = int.Parse((Console.ReadLine()));
                }
            }

            Console.WriteLine("\nDo you want to update any value? (yes/no): ");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "yes")
            {
                Console.Write("Enter the row index to update: ");
                int rowToUpdate = int.Parse((Console.ReadLine()));

                Console.Write("Enter the column index to update: ");
                int columnToUpdate = int.Parse((Console.ReadLine()));

                Console.Write("Enter the new value: ");
                jaggedArray[rowToUpdate][columnToUpdate] = int.Parse((Console.ReadLine()));
            }

            // Step 5: Print the final jagged array
            Console.WriteLine("\nFinal jagged array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
