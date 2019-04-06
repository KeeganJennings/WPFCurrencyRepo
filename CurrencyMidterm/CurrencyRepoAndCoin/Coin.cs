using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMidterm
{
    abstract class Coin : ICoin
    {
        public int year => throw new NotImplementedException();

        public string name => throw new NotImplementedException();

        public int monetary => throw new NotImplementedException();

        public string About()
        {
            throw new NotImplementedException();
        }
    }
}
