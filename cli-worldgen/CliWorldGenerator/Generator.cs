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
            int tilenumber = 1;
            for (int column = 0; column < height; column++)
            {
                for (int row = 0; row < width; row++)
                {
                    maptiles[column, row] = new Tiles.Grass(tilenumber);
                    tilenumber++;
                }
            }
            Map map = new Map(height, width, maptiles);
            return map;
        }
    }
}
