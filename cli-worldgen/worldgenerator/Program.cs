using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CliWorldGenerator;

namespace worldgenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Currently a work in progress...");
            Map map = Generator.GenerateRandom(25, 100);
            Display.displayMap(map);
            Console.ReadLine();
        }
    }
}
