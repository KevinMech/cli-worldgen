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
            while (true)
            {
                Console.WriteLine("Cli World Generator");
                Console.WriteLine("v 0.1.1");
                Console.WriteLine("Currently a work in progress...");
                Console.WriteLine();
                Console.WriteLine("Which generator would you like to try?");
                Console.WriteLine("1. Blank Generation");
                Console.WriteLine("2. Completly Random Generation");
                Console.WriteLine("3. Inland Generation");
                string input = Console.ReadLine();
                Console.Clear();
                switch (input){
                    case "1":
                        {
                            Map map = Generator.GenerateBlank(25, 100);
                            Display.displayMap(map);
                            break;
                        }
                    case "2":
                        {
                            Map map = Generator.GenerateRandom(25, 100);
                            Display.displayMap(map);
                            break;
                        }
                    case "3":
                        {
                            Map map = Generator.InlandGeneration(25, 100);
                            Display.displayMap(map);
                            break;
                        }
                }
                Console.ReadKey();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
            }
        }
    }
}
