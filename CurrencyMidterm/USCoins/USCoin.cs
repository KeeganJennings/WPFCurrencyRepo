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

        private void About()
        {

        }

        public void GetMintNameFromMark()
        {

        }
    }
}
