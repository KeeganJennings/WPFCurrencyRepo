using System;
using System.Collections.Generic;
using System.Text;
using CurrencyMidterm;
using CurrencyRepo;

namespace CurrencyRepo.BarbadosCoins
{
    class TwentyFiveCent : BarbadosCoin
    {
        public TwentyFiveCent()
        {
            tag = "Barbados";
            year = DateTime.Now.Year;
            name = "Twenty Five Cent";
            monetaryValue = 0.25;
        }
        public new string About()
        {
            string about;
            about = About(year, name, monetaryValue);
            return about;
        }
    }
}
