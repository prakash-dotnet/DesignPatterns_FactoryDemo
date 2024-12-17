using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_FactoryDemo
{
    internal class MoneyBack :ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 50000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
