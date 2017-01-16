using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace CliWorldGenerator
{
    public class Generator
    {
        /// <summary>
        /// Initialize map and specify its max width and height.
        /// </summary>
        /// <param name="Height"></param>
        /// <param name="Width"></param>
        public Generator(int Height, int Width)
        {
            Tile [,] Map = new Tile[Height, Width];
            Console.ForegroundColor = System.Drawing.Color.Black;
            int tilenumber = 1;
            Random rand = new Random();
            for (int column = 0; column < Height; column++)
            {
                Console.WriteLine();
                for (int row = 0; row < Width; row++)
                {
                    int random = rand.Next(0,2);
                    if (random == 1) Console.BackgroundColor = System.Drawing.Color.OliveDrab;
                    else Console.BackgroundColor = System.Drawing.Color.LawnGreen;
                    Map[column, row] = new Tile(tilenumber, System.Drawing.Color.Black);
                    Console.Write(" ", Map[column, row].TileColor);
                    tilenumber++;
                }
            }
        }
    }
}
