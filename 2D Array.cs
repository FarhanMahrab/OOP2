using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Define the size of the 2D array
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            // Step 2: Initialize the 2D array
            int[,] array = new int[rows, columns];

            // Step 3: Take input for each element in the 2D array
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Step 4: Optionally, update a specific value in the array
            Console.WriteLine("\nDo you want to update any value? (yes/no): ");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "yes")
            {
                Console.Write("Enter the row index to update: ");
                int rowToUpdate = int.Parse(Console.ReadLine());

                Console.Write("Enter the column index to update: ");
                int columnToUpdate = int.Parse(Console.ReadLine());

                Console.Write("Enter the new value: ");
                array[rowToUpdate, columnToUpdate] = int.Parse(Console.ReadLine());
            }

            // Step 5: Print the final array
            Console.WriteLine("\nFinal array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
