using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMidterm.USCoins
{
    class Penny : USCoin
    {
        MintMarks mintMark;
        public Penny()
        {
            year = DateTime.Now.Year;
            mintMark = MintMarks.D;
            name = "Penny";
            monetaryValue = 0.01;
        }

        public Penny(MintMarks mint)
        {
            year = DateTime.Now.Year;
            mintMark = mint;
            name = "Penny";
            monetaryValue = 0.01;
        }

        public new string About()
        {
            string about;
            about = About(year, name, monetaryValue, mintMark);
            return about;
        }
    }
}
