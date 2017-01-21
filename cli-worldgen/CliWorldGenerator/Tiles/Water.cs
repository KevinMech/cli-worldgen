using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CliWorldGenerator.Tiles
{
    class Water : Tile 
    {
        public override Color TileColor { get; set; }

        public Water(int tilenumber) : base (tilenumber)
        {
            TileColor = Color.DeepSkyBlue;
        }
    }
}
