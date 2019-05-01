using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyRepo.BarbadosCoins;

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

        public ICurrencyRepo CreateChange(double amount, string tag)
        {
            MakeChange(amount, tag);

            return this;
        }

        public ICurrencyRepo CreateChange(double amountTendered, double totalCost, string tag)
        {
            MakeChange(amountTendered, totalCost, tag);


            return this;
        }
        public int GetCoinCount()
        {
            return Coins.Capacity;
        }

        public ICurrencyRepo MakeChange(double amount, string tag)
        {
            double totalAmountOfCoins = 0;

            if (tag == "US Coin")
            {
                while (amount > totalAmountOfCoins)
                {
                    if (totalAmountOfCoins + 1.0 <= amount)
                    {
                        USCoins.DollarCoin dc = new USCoins.DollarCoin();
                        totalAmountOfCoins += dc.monetaryValue;
                        Coins.Add(dc);
                    }
                    else if (totalAmountOfCoins + .25 <= amount)
                    {
                        USCoins.Quarter q = new USCoins.Quarter();
                        totalAmountOfCoins += q.monetaryValue;
                        Coins.Add(q);
                    }
                    else if (totalAmountOfCoins + .1 <= amount)
                    {
                        USCoins.Dime d = new USCoins.Dime();
                        totalAmountOfCoins += d.monetaryValue;
                        Coins.Add(d);
                    }
                    else if (totalAmountOfCoins + .05 <= amount)
                    {
                        USCoins.Nickel n = new USCoins.Nickel();
                        totalAmountOfCoins += n.monetaryValue;
                        Coins.Add(n);
                    }
                    else if (totalAmountOfCoins + .01 <= amount)
                    {
                        USCoins.Penny p = new USCoins.Penny();
                        totalAmountOfCoins += p.monetaryValue;
                        Coins.Add(p);
                    }

                    totalAmountOfCoins = Math.Round(totalAmountOfCoins, 2);
                }
            }
            else if(tag == "Barbados")
            {
                while (amount > totalAmountOfCoins)
                {
                    if (totalAmountOfCoins + 1.0 <= amount)
                    {
                        OneBarbadianDollar oBD = new OneBarbadianDollar();
                        totalAmountOfCoins += oBD.monetaryValue;
                        Coins.Add(oBD);
                    }
                    else if (totalAmountOfCoins + .25 <= amount)
                    {
                        TwentyFiveCent tWC = new TwentyFiveCent();
                        totalAmountOfCoins += tWC.monetaryValue;
                        Coins.Add(tWC);
                    }
                    else if (totalAmountOfCoins + .1 <= amount)
                    {
                        TenCent tC = new TenCent();
                        totalAmountOfCoins += tC.monetaryValue;
                        Coins.Add(tC);
                    }
                    else if (totalAmountOfCoins + .05 <= amount)
                    {
                        FiveCent fC = new FiveCent();
                        totalAmountOfCoins += fC.monetaryValue;
                        Coins.Add(fC);
                    }
                    else if (totalAmountOfCoins + .01 <= amount)
                    {
                        OneCent oC = new OneCent();
                        totalAmountOfCoins += oC.monetaryValue;
                        Coins.Add(oC);
                    }

                    totalAmountOfCoins = Math.Round(totalAmountOfCoins, 2);
                }

            }

            return this;
        }

        public ICurrencyRepo MakeChange(double amountTendered, double totalCost, string tag)
        {
            double change = amountTendered - totalCost;
            double totalAmountOfCoins = 0;

            if (tag == "US Coin")
            {
                while (change > totalAmountOfCoins)
                {
                    if (totalAmountOfCoins + 1 <= change)
                    {
                        USCoins.DollarCoin dc = new USCoins.DollarCoin();
                        totalAmountOfCoins += dc.monetaryValue;
                        Coins.Add(dc);
                    }
                    else if (totalAmountOfCoins + .25 <= change)
                    {
                        USCoins.Quarter q = new USCoins.Quarter();
                        totalAmountOfCoins += q.monetaryValue;
                        Coins.Add(q);
                    }
                    else if (totalAmountOfCoins + .1 <= change)
                    {
                        USCoins.Dime d = new USCoins.Dime();
                        totalAmountOfCoins += d.monetaryValue;
                        Coins.Add(d);
                    }
                    else if (totalAmountOfCoins + .05 <= change)
                    {
                        USCoins.Nickel n = new USCoins.Nickel();
                        totalAmountOfCoins += n.monetaryValue;
                        Coins.Add(n);
                    }
                    else if (totalAmountOfCoins + .01 <= change)
                    {
                        USCoins.Penny p = new USCoins.Penny();
                        totalAmountOfCoins += p.monetaryValue;
                        Coins.Add(p);
                    }
                }
            }
            else if(tag == "Barbados")
            {
                if (totalAmountOfCoins + 1.0 <= change)
                {
                    OneBarbadianDollar oBD = new OneBarbadianDollar();
                    totalAmountOfCoins += oBD.monetaryValue;
                    Coins.Add(oBD);
                }
                else if (totalAmountOfCoins + .25 <= change)
                {
                    TwentyFiveCent tWC = new TwentyFiveCent();
                    totalAmountOfCoins += tWC.monetaryValue;
                    Coins.Add(tWC);
                }
                else if (totalAmountOfCoins + .1 <= change)
                {
                    TenCent tC = new TenCent();
                    totalAmountOfCoins += tC.monetaryValue;
                    Coins.Add(tC);
                }
                else if (totalAmountOfCoins + .05 <= change)
                {
                    FiveCent fC = new FiveCent();
                    totalAmountOfCoins += fC.monetaryValue;
                    Coins.Add(fC);
                }
                else if (totalAmountOfCoins + .01 <= change)
                {
                    OneCent oC = new OneCent();
                    totalAmountOfCoins += oC.monetaryValue;
                    Coins.Add(oC);
                }
            }

            return this;
        }

        public ICoin RemoveCoin(ICoin c)
        {
            for(int i = 0; i < Coins.Capacity; i++)
            {
                if (Coins[i].GetType() == c.GetType())
                {
                    Coins.RemoveAt(i);
                    i = Coins.Count + 1;
                }
            }
            return c;
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
