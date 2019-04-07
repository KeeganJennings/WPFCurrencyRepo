using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMidterm.USCoins
{
    class DollarCoin : USCoin
    {
        MintMarks mintMark;
        public DollarCoin()
        {
            year = DateTime.Now.Year;
            mintMark = MintMarks.D;
            name = "Dollar Coin";
            monetaryValue = 1.00;
        }

        public DollarCoin(MintMarks mint)
        {
            year = DateTime.Now.Year;
            mintMark = mint;
            name = "Dollar Coin";
            monetaryValue = 1.00;
        }

        public new string About()
        {
            string about;
            about = About(year, name, monetaryValue, mintMark);
            return about;
        }
    }
}
