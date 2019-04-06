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

        }
        public string About()
        {
            throw new NotImplementedException();
        }

        public void AddCoin(ICoin c)
        {
            throw new NotImplementedException();
        }

        public ICurrency CreateChange(double amount)
        {

        }

        public ICurrency CreateChange(double amountTendered, double TotalCost)
        {

        }
        public int GetCoinCount()
        {
            throw new NotImplementedException();
        }

        public ICurrencyRepo MakeChange(double amount)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
