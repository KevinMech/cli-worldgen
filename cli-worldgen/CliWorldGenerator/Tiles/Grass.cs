using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CliWorldGenerator.Tiles
{
    class Grass : Tile 
    {
        public override Color TileColor { get; set; }

        public Grass(int tilenumber) : base (tilenumber)
        {
            TileColor = Color.LawnGreen;
        }
    }
}
