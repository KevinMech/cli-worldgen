using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CliWorldGenerator
{
    public abstract class Tile
    {
        public int TileNumber { get; set; }
        public abstract Color TileColor { get; set; }

        public Tile(int tilenumber)
        {
            TileNumber = tilenumber;
        }
    }
}
