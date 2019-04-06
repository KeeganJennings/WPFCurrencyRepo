using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMidterm
{
    abstract class Coin : ICoin
    {
        public int year { get;  }

        public string name { get { return ""; } }

        public int monetary { get { return 0; } }

        public string About()
        {
            return "";
        }
    }
}
