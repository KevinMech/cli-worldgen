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
            Generator.generate(25, 100);
            Console.ReadLine();
        }
    }
}
