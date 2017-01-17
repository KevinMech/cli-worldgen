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
        /// <param name="height"></param>
        /// <param name="width"></param>
        public static Map generate(int height, int width)
        {
            Tile[,] maptiles = new Tile[height, width];
            Console.ForegroundColor = System.Drawing.Color.Black;
            int tilenumber = 1;
            Random rand = new Random();
            for (int column = 0; column < height; column++)
            {
                Console.WriteLine();
                for (int row = 0; row < width; row++)
                {
                    int random = rand.Next(0, 2);
                    if (random == 1) Console.BackgroundColor = System.Drawing.Color.OliveDrab;
                    else Console.BackgroundColor = System.Drawing.Color.LawnGreen;
                    maptiles[column, row] = new Tile(tilenumber, System.Drawing.Color.Black);
                    Console.Write(" ", maptiles[column, row].TileColor);
                    tilenumber++;
                }
            }
            Map map = new Map(height, width, maptiles);
            return map;
        }
    }
}
