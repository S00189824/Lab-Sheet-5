using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game g1 = new Game("COD", 60.00m,new DateTime (2019,11,04));
            //Game g2 = new Game("Astellia Online", 10.00m,new DateTime (2019,08,25));
            //Game g3 = new Game("Final Fantasy XIV");
            //Game g4 = new Game("GTA", 10.99m);

            //Console.WriteLine(g1);
            //Console.WriteLine(g2);

            ComputerGameClass cg1 = new ComputerGameClass("FFxiv", 60.00m, new DateTime (2019, 11, 04), "U");
            ComputerGameClass cg2 = new ComputerGameClass("GTA", 55.00m, new DateTime (2018, 01, 04), "18");

            //DisplayGame(g1);
            //DisplayGame(g2);
            DisplayGame(cg2);
            DisplayGame(cg1);
        }

        public static void DisplayGame(Game game)
        {
            Console.WriteLine(game);
        }
    }
}
