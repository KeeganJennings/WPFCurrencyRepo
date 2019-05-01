using System;
using System.Collections.Generic;
using System.Text;
using CurrencyMidterm;
using CurrencyRepo;

namespace CurrencyRepo.BarbadosCoins
{
    class OneBarbadianDollar : BarbadosCoin
    {
        public OneBarbadianDollar()
        {
            tag = "Barbados";
            year = DateTime.Now.Year;
            name = "One Bardian Dollar";
            monetaryValue = 1;
        }
        public new string About()
        {
            string about;
            about = About(year, name, monetaryValue);
            return about;
        }
    }
}
