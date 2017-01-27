using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliWorldGenerator
{
    public class Generator
    {
        /// <summary>
        /// Create and initiliaze a new, blank map full of grass tiles
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public static Map GenerateBlank(int height, int width)
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

        /// <summary>
        /// Generate a map with tiles placed around at completly random places
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public static Map GenerateRandom(int height, int width)
        {
            Random random = new Random();
            Tile[,] maptiles = new Tile[height, width];
            int tilenumber = 1;
            for (int column = 0; column < height; column++)
            {
                for (int row = 0; row < width; row++)
                {
                    int rand = random.Next(0, 2);
                    if (rand == 1) maptiles[column, row] = new Tiles.Grass(tilenumber);
                    else maptiles[column, row] = new Tiles.Water(tilenumber);
                    tilenumber++;
                }
            }
            Map map = new Map(height, width, maptiles);
            return map;
        }

        /// <summary>
        /// Generate land that is within a continent, which can be optionally surrounded by water
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="treeDensity"></param>
        /// <returns></returns>
        public static Map InlandGeneration(int height, int width, int treeDensity)
        {
            Random rand = new Random();
            Map map = GenerateBlank(height, width);

            //Generate Trees onto map
            for (int column = 0; column < height; column++)
            {
                for (int row = 0; row < width; row++)
                {
                    int treechance = rand.Next(0, 100);
                    if(treechance < treeDensity)
                    {
                        map.MapTiles[column, row].Ontop = Tile.Objects.Tree;
                    }
                }
            }
            return map;
        }
    }
}
