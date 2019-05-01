using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMidterm.USCoins
{
    abstract class USCoin : Coin
    {
        public enum MintMarks
        {
            P,
            D,
            S,
            W
        }

        MintMarks mintMark;
        public string tag;

        public string About(int year, string name, double monetaryValue, MintMarks mint)
        {
            return $"US " + name + " is from " + year + ". It is worth $" + monetaryValue + ". It was made in " + GetMintNameFromMark(mint) + ".";
        }

        public string GetMintNameFromMark(MintMarks marks)
        {
            string mintName = "";
            switch(marks)
            {
                case MintMarks.P:
                    mintName = "Philadelphia";
                    break;
                case MintMarks.D:
                    mintName = "Delaware";
                    break;
                case MintMarks.S:
                    mintName = "San Francisco";
                    break;
                case MintMarks.W:
                    mintName = "West Point";
                    break;

            }

            return mintName;
        }
    }
}
