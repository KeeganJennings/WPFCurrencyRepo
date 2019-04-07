using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMidterm
{
    interface ICoin : ICurrency
    {
        int year { get; }
    }
}
