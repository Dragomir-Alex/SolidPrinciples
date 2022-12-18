using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability_Orders_Demo.Logic.Services
{
    public class PaymentService
    {
        public void ChargeCard(CreditCardDetails creditCardDetails, Cart cart)
        {
            // Get sum of money from the credit card
            Console.WriteLine("ChargeCard");
        }
    }
}
