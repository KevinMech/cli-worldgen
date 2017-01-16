using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliWorldGenerator
{
    class Tile
    {
        public int tilenumber { get; }
        public ConsoleColor tileColor = ConsoleColor.Green;

        public Tile(int tileNumber)
        {
            tilenumber = tileNumber;
        }
    }
}
