using CurrencyMidterm;
using CurrencyRepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRepo.BarbadosCoins
{
    class FiveCent : BarbadosCoin
    {
        public FiveCent()
        {
            tag = "Barbados";
            year = DateTime.Now.Year;
            name = "Five Cent";
            monetaryValue = 0.05;
        }
        public new string About()
        {
            string about;
            about = About(year, name, monetaryValue);
            return about;
        }
    }
}
