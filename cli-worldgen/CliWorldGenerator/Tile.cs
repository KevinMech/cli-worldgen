using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Colorful;

namespace CliWorldGenerator
{
    public class Tile
    {
        public int TileNumber { get; }
        public Color TileColor { get; } = Color.LawnGreen;

        public Tile(int tilenumber, Color tilecolor)
        {
            TileNumber = tilenumber;
            TileColor = tilecolor;
        }
    }
}
