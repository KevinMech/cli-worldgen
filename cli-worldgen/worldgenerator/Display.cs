﻿using System;
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
        public static void displayMap(Map map)
        {
            for (int column = 0; column < map.Height; column++)
            {
                Console.WriteLine();
                for (int row = 0; row < map.Width; row++)
                {
                    Console.BackgroundColor = map.MapTiles[column, row].TileColor;
                    Console.Write(" ");
                }
            }
        }
    }
}