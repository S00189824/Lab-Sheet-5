using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_5
{
    public abstract class Game
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

       protected decimal price { get; set; } //protected will allow me to use in child class computerGameClass
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
            return string.Format($"{_name} {price}  {ReleaseDate.ToShortDateString() }");
        }

        public abstract void UpdatePrice(decimal percentageIncrease);
        //{
        //    price *= (1 + percentageIncrease);
        //}

    }
}
