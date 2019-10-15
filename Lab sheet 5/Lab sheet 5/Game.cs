using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_5
{
    public class Game
    {
        private readonly string _name;
        
        public string name
        {
            get
            {
                return _name;// getting name but because its private you can now only 
                //get name and not set it.
            }
        }

        public decimal price { get; set; }
       public  DateTime ReleaseDate { get; set; }

        public Game (string Name,decimal Price,DateTime releaseDate)
        {
            _name = Name;
            price = Price;
            ReleaseDate = releaseDate;


        }

        public Game(string name, decimal price) : this(name, price, DateTime.Now) { }

        public Game(string name):this(name, 0)
        {

        }

        public Game()
        {

        }

        public override string ToString()
        {
            return string.Format($"{_name} {price} {PegiRating} {ReleaseDate.ToShortDateString()}");
        }
    }
}
