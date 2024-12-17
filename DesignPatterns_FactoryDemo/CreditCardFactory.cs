using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_FactoryDemo
{
    //creating Factory class
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard myCard = null;
            if (cardType == "MoneyBack")
            {
                myCard = new MoneyBack();
            }
            else if (cardType == "GoldCard")
            {
                myCard = new GoldCard();
            }
            else if (cardType == "PlatinumCard")
            {
                myCard = new PlatinumCard();
            }
            return myCard;
        }
    }
}
