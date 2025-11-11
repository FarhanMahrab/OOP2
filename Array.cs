using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //By assigning the data
            String[] cars = { "Toyota", "Tesla", "Marcedez", "Porshe" };
            cars[0] = "Honda";

            //Printing all the data
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }*/

            //Taking input from the user when we do not know the size
            Console.WriteLine("Please enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            String[] players = new string[size];

            
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Please input the { i + 1} player name:");
                players[i] = Console.ReadLine();
            }

            for (int i = 0; i < players.Length; i++) 
            {
                Console.WriteLine($"Player number {i+1} is: {players[i]}");
            }
            Console.ReadKey();
        }
    }
}
