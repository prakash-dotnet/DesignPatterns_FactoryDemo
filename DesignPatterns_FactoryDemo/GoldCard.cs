using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_FactoryDemo
{
    internal class GoldCard : ICreditCard
    {
            public string GetCardType()
            {
                return "Gold Card";
            }
            public int GetCreditLimit()
            {
                return 75000;
            }
            public int GetAnnualCharge()
            {
                return 750;
            }
        
    }
}
