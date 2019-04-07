using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMidterm
{
    class CurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get; set; }

        public CurrencyRepo()
        {
            this.Coins = new List<ICoin>();
        }

        public string About()
        {
            throw new NotImplementedException();
        }

        public void AddCoin(ICoin c)
        {
            Coins.Add(c);
        }

        public ICurrencyRepo CreateChange(double amount)
        {


            return this;
        }

        public ICurrencyRepo CreateChange(double amountTendered, double TotalCost)
        {
            double change = amountTendered - TotalCost;


            return this;
        }
        public int GetCoinCount()
        {
            return Coins.Capacity;
        }

        public ICurrencyRepo MakeChange(double amount)
        {
            double totalAmountOfCoins = 0;


            if (amount > totalAmountOfCoins)
            {
                if (totalAmountOfCoins + 1 > amount)
                {
                    USCoins.DollarCoin dc = new USCoins.DollarCoin();
                    Coins.Add(dc);
                }
                else if (totalAmountOfCoins + .25 > amount)
                {
                    USCoins.Quarter q = new USCoins.Quarter();
                    Coins.Add(q);
                }
                else if (totalAmountOfCoins + .1 > amount)
                {
                    USCoins.Dime d = new USCoins.Dime();
                    Coins.Add(d);
                }
                else if (totalAmountOfCoins + .05 > amount)
                {
                    USCoins.Nickel n = new USCoins.Nickel();
                    Coins.Add(n);
                }
                else if (totalAmountOfCoins + .01 > amount)
                {
                    USCoins.Penny p = new USCoins.Penny();
                    Coins.Add(p);
                }
            }

            return totalAmountOfCoins;
        }

        public ICurrencyRepo MakeChange(double amountTendered, double totalCost)
        {
            throw new NotImplementedException();
        }

        public ICoin RemoveCoin(ICoin c)
        {
            throw new NotImplementedException();
        }

        public double TotalValue()
        {
            double totalValue = 0;

            foreach(Coin c in Coins)
            {
                totalValue += c.monetaryValue;
            }

            return totalValue;
        }
    }
}
