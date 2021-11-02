using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] game = Task_02112021.shipCreator();

            for (int i = 0; i < game.GetLength(0); i++)
            {
                for (int j = 0; j < game.GetLength(1); j++)
                {
                    Console.Write(game[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
