using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMidterm
{
    interface ICurrency
    {
        string name { get; }
        int monetary { get; }
        string About();
    }
}
