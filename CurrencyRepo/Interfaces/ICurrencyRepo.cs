using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMidterm
{
    interface ICurrencyRepo
    {
        List<ICoin> Coins { get; set; }

        string About();
        void AddCoin(ICoin c);
        int GetCoinCount();

        ICurrencyRepo MakeChange(double amount, string tag);
        ICurrencyRepo MakeChange(double amountTendered, double totalCost, string tag);

        ICoin RemoveCoin(ICoin c);

        double TotalValue();
    }
}
