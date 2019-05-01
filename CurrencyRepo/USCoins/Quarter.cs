using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMidterm.USCoins
{
    class Quarter : USCoin
    {
        MintMarks mintMark;
        public Quarter()
        {
            tag = "US Coin";
            year = DateTime.Now.Year;
            mintMark = MintMarks.D;
            name = "Quarter";
            monetaryValue = 0.25;
        }

        public Quarter(MintMarks mint)
        {
            tag = "US Coin";
            year = DateTime.Now.Year;
            mintMark = mint;
            name = "Quarter";
            monetaryValue = 0.25;
        }

        public new string About()
        {
            string about;
            about = About(year, name, monetaryValue, mintMark);
            return about;
        }
    }
}
