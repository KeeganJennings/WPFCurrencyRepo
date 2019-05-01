using System;
using System.Collections.Generic;
using System.Text;
using CurrencyMidterm;
using CurrencyRepo;

namespace CurrencyRepo.BarbadosCoins
{
    class OneCent : BarbadosCoin
    {
        public OneCent()
        {
            tag = "Barbados";
            year = DateTime.Now.Year;
            name = "One Cent";
            monetaryValue = 0.01;
        }
        public new string About()
        {
            string about;
            about = About(year, name, monetaryValue);
            return about;
        }
    }
}
