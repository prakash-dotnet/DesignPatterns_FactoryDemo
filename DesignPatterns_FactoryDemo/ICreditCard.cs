using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_FactoryDemo
{
    public interface ICreditCard
    {
            string GetCardType();
            int GetCreditLimit();
            int GetAnnualCharge();
      
    }
}
