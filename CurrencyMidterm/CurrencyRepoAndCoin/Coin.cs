using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMidterm
{
    abstract class Coin : ICoin
    {
        public int year { get; set; }

        public string name { get; set; }

        public double monetaryValue { get; set; }

        public string About()
        {
            return "";
        }
    }
}
