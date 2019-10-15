using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_5
{
    class Game
    {
        string name { get; set; }
        decimal price { get; set; }
        DateTime ReleaseDate { get; set; }

        public Game (string Name,decimal Price,DateTime releaseDate)
        {
            name = Name;
            price = Price;
            ReleaseDate = releaseDate;


        }

        public Game(string name, decimal price) : this(name, price, DateTime.Now) { }

        public Game(string name):this(name, 0)
        {

        }
    }
}
