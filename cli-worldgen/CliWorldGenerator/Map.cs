using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliWorldGenerator
{
    public class Map
    {
        public int Height { get; }
        public int Width { get; }
        public Tile[,] MapTiles { get; }
        public int NumberofTiles { get; }

        public Map(int height, int width, Tile[,] maptiles)
        {
            Height = height;
            Width = width;
            MapTiles = maptiles;
            NumberofTiles = height * width;
        }
    }
}
