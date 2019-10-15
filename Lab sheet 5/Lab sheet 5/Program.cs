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
            Game g1 = new Game("COD", 60.00m,new DateTime(04,11,2019));
            Game g2 = new Game("Astellia Online", 10.00m,new DateTime(25,08,2019));

            Game g3 = new Game("Final Fantasy XIV");

            Game g4 = new Game("GTA", 10.99m);
        }
    }
}
