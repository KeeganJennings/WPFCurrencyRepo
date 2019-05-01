using CurrencyMidterm;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRepo.BarbadosCoins
{
    abstract class BarbadosCoin : Coin
    {
        public string tag;
        public string About(int year, string name, double monetaryValue)
        {
            return "Barbados " + name + " is from " + year + ". It is worth $" + monetaryValue + ". They all come from the Barbdian Mint.";
        }
    }
}
