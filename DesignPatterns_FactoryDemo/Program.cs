using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_FactoryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  //without using Factory Pattern
           string cardType = "MoneyBack";
            ICreditCard myCard= null;
             
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
            if (myCard != null)
            {
                Console.WriteLine("Card Type : " + myCard.GetCardType());
                Console.WriteLine("Credit Limit : " + myCard.GetCreditLimit());
                Console.WriteLine("Annual Charges :" + myCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type.!!!");
            }

            Console.ReadKey(); */

            //using Factory Pattern
            ICreditCard myCard2 = CreditCardFactory.GetCreditCard("MoneyBack");

            if (myCard2 != null)
            {
                Console.WriteLine("Card Type : " + myCard2.GetCardType());
                Console.WriteLine("Credit Limit : " + myCard2.GetCreditLimit());
                Console.WriteLine("Annual Charges :" + myCard2.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type..!!!");
            }
 
            Console.ReadKey();
           
        }
    }
}
