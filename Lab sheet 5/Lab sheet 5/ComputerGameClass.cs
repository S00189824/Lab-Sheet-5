using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_5
{
    public class ComputerGameClass:Game
    {
        public string PegiRating { get; set; }

        public decimal GetDiscountPrice()
        {
            return price * .9m;
            
        }

        public ComputerGameClass(string name, decimal price, DateTime releaseDate,string pegi)
            : base(name, price, releaseDate)
        {
            PegiRating = pegi;
        }

        public override string ToString()
        {
            return string.Format($"{base.ToString()} PEGI {PegiRating}");
        }

        public override void UpdatePrice(decimal percentageIncrease)
        {
            price *= (1 + percentageIncrease);
            Console.WriteLine("Updating the price");
        }


    }
}
