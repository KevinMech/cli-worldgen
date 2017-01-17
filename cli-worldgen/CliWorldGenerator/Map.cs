using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliWorldGenerator
{
    class Map
    {
        int Height { get; }
        int Width { get; }
        Tile[,] MapTiles { get; }
        int NumberofTiles { get; }

        public Map(int height, int width, Tile[,] maptiles)
        {
            Height = height;
            Width = width;
            MapTiles = maptiles;
            NumberofTiles = height * width;
        }
    }
}
