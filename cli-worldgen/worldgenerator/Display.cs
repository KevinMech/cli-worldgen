using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
using CliWorldGenerator;

namespace worldgenerator
{
    class Display
    {
        /// <summary>
        /// Draws the map onto the screen
        /// </summary>
        /// <param name="map">Map that will be drawn onto screen</param>
        public static void displayMap(Map map)
        {
            for (int column = 0; column < map.Height; column++)
            {
                Console.WriteLine();
                for (int row = 0; row < map.Width; row++)
                {
                    //Draws the color of the currently selected tile onto the screen
                    Console.BackgroundColor = map.MapTiles[column, row].TileColor;
                    //Draws the object ontop of the tile if one exists
                    switch(map.MapTiles[column, row].Ontop)
                    {
                        case Tile.Objects.Tree:
                            Console.ForegroundColor = System.Drawing.Color.Brown;
                            Console.Write("T");
                            break;

                        default:
                            Console.Write(" ");
                            break;
                    }
                }
            }
            Console.ForegroundColor = System.Drawing.Color.White;
            Console.BackgroundColor = System.Drawing.Color.Black;
        }
    }
}
