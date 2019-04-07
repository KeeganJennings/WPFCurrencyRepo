using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMidterm.USCoins
{ 
    class Dime : USCoin
    {
        MintMarks mintMark;
        public Dime()
        {
            year = DateTime.Now.Year;
            mintMark = MintMarks.D;
            name = "Dime";
            monetaryValue = 0.10;
        }

        public Dime(MintMarks mint)
        {
            year = DateTime.Now.Year;
            mintMark = mint;
            name = "Dime";
            monetaryValue = 0.10;
        }

        public new string About()
        {
            string about;
            about = About(year, name, monetaryValue, mintMark);
            return about;
        }
    }
}
