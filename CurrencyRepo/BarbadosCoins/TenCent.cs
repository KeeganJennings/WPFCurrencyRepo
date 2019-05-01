using System;
using System.Collections.Generic;
using System.Text;
using CurrencyMidterm;
using CurrencyRepo;

namespace CurrencyRepo.BarbadosCoins
{
    class TenCent : BarbadosCoin
    {
        public TenCent()
        {
            tag = "Barbados";
            year = DateTime.Now.Year;
            name = "Ten Cent";
            monetaryValue = 0.10;
        }
        public new string About()
        {
            string about;
            about = About(year, name, monetaryValue);
            return about;
        }
    }
}
