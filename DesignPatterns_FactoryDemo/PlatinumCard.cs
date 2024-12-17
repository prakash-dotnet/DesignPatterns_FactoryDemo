using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_FactoryDemo
{
    internal class PlatinumCard : ICreditCard
    {

         public string GetCardType()
        {
            return "Platinum Card";
        }
            public int GetCreditLimit()
            {
                return 100000;
            }
            public int GetAnnualCharge()
            {
                return 1000;
            }

        }
    
}
