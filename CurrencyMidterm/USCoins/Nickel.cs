using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMidterm.USCoins
{
    class Nickel : USCoin
    {
        MintMarks mintMark;
        public Nickel()
        {
            year = DateTime.Now.Year;
            mintMark = MintMarks.D;
            name = "Nickel";
            monetaryValue = 0.05;
        }
        public Nickel(MintMarks mint)
        {
            year = DateTime.Now.Year;
            mintMark = mint;
            name = "Nickel";
            monetaryValue = 0.05;
        }

        public new string About()
        {
            string about;
            about = About(year, name, monetaryValue, mintMark);
            return about;
        }
    }
}
